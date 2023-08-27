using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using AVC___remake.Forms;
using System.Threading;

namespace AVC___remake.Scripts
{
    public class SerialPortCommunication
    {
        private Main main1;
        private ModbusSlave modbusSlave1;
        private SerialPort serialPort1;
        public void Start(SerialPort serialPort, ModbusSlave modbusSlave, Main main)
        {
            main1 = main;
            modbusSlave1 = modbusSlave;
            serialPort1 = serialPort;
        }

        public void AddDataReceivedEvenHandler()
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
        }

        public void RemoveDataReceivedEvenHandler()
        {
            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
        }

        private byte[] bytesRead;
        private byte[] dataReceived;
        private byte[] lastDataReceived = new byte[0];

        private int dataReceivedLength;
        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            int bytesToRead = serialPort1.BytesToRead;
            if (bytesToRead > 0)
            {
                //if (bytesToRead < 3)
                //{
                //    bytesRead = new byte[bytesToRead];
                //    serialPort1.Read(bytesRead, 0, bytesToRead);
                //    serialPort1.DiscardInBuffer();
                //    main1.PrintlnDebug(BitConverter.ToString(bytesRead));
                //    return;
                //}

                //serialPort1.DiscardNull = true;

                bytesRead = new byte[bytesToRead];
                serialPort1.Read(bytesRead, 0, bytesToRead);

                if (lostDataReceived)
                {
                    dataReceivedLength += bytesToRead;
                    Array.Resize(ref dataReceived, dataReceivedLength);
                    Array.Copy(bytesRead, 0, dataReceived, dataReceivedLength - bytesToRead, bytesToRead);
                }
                else
                {
                    dataReceivedLength = bytesToRead;
                    dataReceived = new byte[dataReceivedLength];
                    Array.Copy(bytesRead, dataReceived, dataReceivedLength);
                }

                //if (lastDataReceived.SequenceEqual(dataReceived))
                //{
                //    //Thread.Sleep(150);
                //}

                //lastDataReceived = new byte[dataReceivedLength];
                //Array.Copy(dataReceived, lastDataReceived, dataReceivedLength);

                serialPort1.DiscardInBuffer();

                //System.Threading.ThreadPool.QueueUserWorkItem((o) =>
                //{
                //    serialPort1.DiscardInBuffer();
                //    //serialPort1.DiscardNull = false;
                //});

                //main1.PrintlnDebug(BitConverter.ToString(bytesRead));

                //bytesRead = new byte[] { };
                //bytesRead = serialPort1.Encoding.GetBytes(serialPort1.ReadExisting());
                //bytesToRead = bytesRead.Length;

                ProcessDataReceived(dataReceived, dataReceivedLength);

                //try
                //{
                //    System.Threading.ThreadPool.QueueUserWorkItem(delegate { ProcessDataReceived(dataReceived, dataReceivedLength); });
                //}
                //catch(Exception ex)
                //{
                //    throw ex;
                //}
                //ProcessDataReceived(bytesRead, bytesToRead);

            }
        }

        private byte slaveAddress, function, byteCount;
        private ushort startingAddress, noAddress, crc;
        bool lostDataReceived;
        byte[] responseData;

        void ProcessDataReceived(byte[] rawData, int rawDataLength)
        {
            if (rawDataLength < 2)
            {
                lostDataReceived = true;
                return;
            }

            slaveAddress = rawData[0];
            if (slaveAddress != modbusSlave1.slaveAddress)
                return;

            function = rawData[1];
            if (function == 0x03)
            {
                if (rawDataLength < 8)
                {
                    lostDataReceived = true;
                    return;
                }
                else
                    lostDataReceived = false;
            }
            else if (function == 0x10)
            {
                if (rawDataLength < 7)
                {
                    lostDataReceived = true;
                    return;
                }
                else if (rawDataLength < (9 + rawData[6]))
                {
                    lostDataReceived = true;
                    return;
                }
                else lostDataReceived = false;
            }
            else
            {
                lostDataReceived = false;
                return;
            }

            crc = (ushort)((rawData[rawDataLength - 1] << 8) | rawData[rawDataLength - 2]);
            ushort crcRegister = GeneratingCRC(rawData, rawDataLength);
            if (crc != crcRegister)
            {
                //main1.PrintlnDebug("crc Not match:");
                //main1.PrintlnDebug(BitConverter.ToString(rawData));
                return;
            }

            switch (function)
            {
                case 0x03:
                    {
                        Function3H(rawData);
                        break;
                    }
                case 0x10:
                    {
                        Function10H(rawData);
                        break;
                    }
                default:
                    {
                        //main1.PrintlnDebug("No Function match:");
                        //main1.PrintlnDebug(BitConverter.ToString(rawData));
                        return;
                    }
            }
            
        }

        void Function3H(byte[] rawData)
        {
            //
            startingAddress = (ushort)((rawData[2] << 8) | rawData[3]);
            noAddress = (ushort)((rawData[4] << 8) | rawData[5]);

            //Response Code:
            int responseDataLength = 5 + noAddress * 2;
            responseData = new byte[responseDataLength];
            {
                responseData[0] = slaveAddress;
                responseData[1] = function;
                responseData[2] = (byte)(noAddress * 2);

                //Read Data from Register Code:
                for (ushort i = 0; i < noAddress; i++)
                {
                    ushort registerValue = modbusSlave1.GetRegisterValue((ushort)(startingAddress + i));
                    responseData[3 + i * 2] = (byte)(registerValue >> 8 & 0x00FF);
                    responseData[4 + i * 2] = (byte)(registerValue & 0x00FF);
                }
            }
            ushort crcResponseData = GeneratingCRC(responseData, responseDataLength);
            byte[] crcResponseDataConvert = new byte[2] { (byte)(crcResponseData & 0xFF), (byte)((crcResponseData >> 8) & 0xFF) };
            Array.Copy(crcResponseDataConvert, 0, responseData, responseDataLength - 2, 2);

            //Thread.Sleep(10);

            serialPort1.Write(responseData, 0, responseDataLength);

            //main1.PrintlnDebug(BitConverter.ToString(responseData));
        }

        void Function10H(byte[] rawData)
        {
            //
            startingAddress = (ushort)((rawData[2] << 8) | rawData[3]);
            noAddress = (ushort)((rawData[4] << 8) | rawData[5]);
            byteCount = rawData[6];

            byte[] byteData = new byte[byteCount];
            Array.Copy(rawData, 7, byteData, 0, byteCount);

            convertObj obj = new convertObj();
            obj.SetValue(startingAddress, noAddress, byteCount, byteData);

            //Write Data to Register Code:
            Thread thread1 = new Thread(threadSetRegisterValue);
            thread1.Start(obj);

            //Response Code:
            responseData = new byte[8];
            Array.Copy(rawData, responseData, 6);
            ushort crcResponseData = GeneratingCRC(responseData, 8);
            byte[] crcResponseDataConvert = new byte[2] { (byte)(crcResponseData & 0xFF), (byte)((crcResponseData >> 8) & 0xFF) };
            Array.Copy(crcResponseDataConvert, 0, responseData, 6, 2);

            //Thread.Sleep(10);
                        
            serialPort1.Write(responseData, 0, 8);
        }

        ushort GeneratingCRC(byte[] rawData, int rawDataLength)
        {
            ushort crcTemp = 0xFFFF;

            for (int i = 0; i < rawDataLength - 2; i++)
            {
                crcTemp ^= (ushort)rawData[i];

                for (int j = 0; j < 8; j++)
                {
                    if ((crcTemp & 0x0001) != 0)
                    {
                        crcTemp >>= 1;
                        crcTemp ^= 0xA001;
                    }
                    else
                        crcTemp >>= 1;
                }
            }
            return crcTemp;
        }

        struct convertObj
        {
            public ushort startingAddress;
            public ushort noAddress;
            public byte byteCount;
            public byte[] byteData;
            public void SetValue(ushort starting_Address, ushort no_Address, byte byte_Count, byte[] byte_Data)
            {
                startingAddress = starting_Address;
                noAddress = no_Address;
                byteCount = byte_Count;
                byteData = byte_Data;
            }
        }

        void threadSetRegisterValue(object objTemp)
        {
            convertObj obj = (convertObj)objTemp;
            byte byteIndex = 0;
            for (ushort i = 0; i < obj.noAddress; i++)
            {
                ushort value = (ushort)((obj.byteData[byteIndex] << 8) | obj.byteData[byteIndex + 1]);
                byteIndex += 2;
                if (byteIndex >= obj.byteCount)
                    byteIndex = 0;
                modbusSlave1.SetRegisterValue((ushort)(obj.startingAddress + i), value);
            }
        }
        
    }
}
