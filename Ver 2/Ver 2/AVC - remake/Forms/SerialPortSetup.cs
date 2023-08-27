using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AVC___remake;
using AVC___remake.Scripts;

namespace AVC___remake.Forms
{
    public partial class SerialPortSetup : Form
    {
        private Parity[] parity = { Parity.Odd, Parity.Even, Parity.Mark, Parity.Space };
        private StopBits[] stopBits = { StopBits.One, StopBits.OnePointFive, StopBits.Two };
        private SerialPort serialPort1;
        private SerialPortCommunication serialPortCommunication;
        public SerialPortSetup(SerialPort serialPort, SerialPortCommunication serialPortCommunication)
        {
            InitializeComponent();
            
            serialPort1 = serialPort;
            this.serialPortCommunication = (Scripts.SerialPortCommunication) serialPortCommunication;

            if (serialPort1.IsOpen)
            {
                t_Scan.Enabled = false;
                cB_Name.Items.Add(serialPort1.PortName);
                cB_Name.SelectedIndex = cB_Name.Items.Count - 1;
                bt_Connect.Text = "Disconnect";
            }
            else
            {
                t_Scan.Enabled = true;
                bt_Connect.Text = "Connect";
            }

            cB_BaudRate.SelectedIndex = 1;
            cB_DataBits.SelectedIndex = 0;
            cB_Parity.SelectedIndex = 1;
            cB_StopBits.SelectedIndex = 0;

        }

        private int portsLength;
        private void t_Scan_Tick(object sender, EventArgs e)
        {
            string[] portsTemp = SerialPort.GetPortNames();
            if (portsLength != portsTemp.Length)
            {
                cB_Name.Items.Clear();
                cB_Name.Items.AddRange(portsTemp);
                portsLength = portsTemp.Length;
            }
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPortCommunication.RemoveDataReceivedEvenHandler();
                    serialPort1.Dispose();
                    //serialPort1.DiscardInBuffer();
                    //serialPort1.DiscardOutBuffer();
                    serialPort1.Close();

                    t_Scan.Enabled = true;

                    bt_Connect.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                if (cB_Name.Text == string.Empty)
                    return;
                serialPort1.PortName = cB_Name.Text;
                serialPort1.BaudRate = int.Parse(cB_BaudRate.Text);
                serialPort1.DataBits = int.Parse(cB_DataBits.Text);
                serialPort1.StopBits = stopBits[cB_StopBits.SelectedIndex];
                serialPort1.Parity = parity[cB_Parity.SelectedIndex];

                try
                {
                    serialPort1.Open();
                    serialPortCommunication.AddDataReceivedEvenHandler();

                    t_Scan.Enabled = false;

                    bt_Connect.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
