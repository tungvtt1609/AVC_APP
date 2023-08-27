using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC___remake.Scripts
{
    public class ModbusSlave
    {
        public byte slaveAddress;
        private Register[] registers;
        private int readRegistersCount = 0;
        private int startReadRegisterAddress = 0;
        private int writeRegistersCount = 0;
        private int startWriteRegisterAddress;

        public void GeneralSlave(int _readRegistersCount, int _startReadRegisterAddress, int _writeRegistersCount, int _startWriteRegisterAddress)
        {
            readRegistersCount = _readRegistersCount;
            writeRegistersCount = _writeRegistersCount;
            startReadRegisterAddress = _startReadRegisterAddress;
            startWriteRegisterAddress = _startWriteRegisterAddress;

            registers = new Register[readRegistersCount + writeRegistersCount];

            for (ushort i = 0; i < readRegistersCount; i++)
            {
                registers[i] = new Register();
                registers[i].registerAddress = (ushort)(startReadRegisterAddress + i);
                registers[i].registerValue = 0;
            }

            for (ushort i = 0; i < writeRegistersCount; i++)
            {
                registers[readRegistersCount + i] = new Register();
                registers[readRegistersCount + i].registerAddress = (ushort)(startWriteRegisterAddress + i);
                registers[readRegistersCount + i].registerValue = 0;
            }
        }

        public Register GetRegister(ushort address)
        {
            if (address < readRegistersCount + startReadRegisterAddress && address >= startReadRegisterAddress)
            {
                return registers[address - startReadRegisterAddress];
            }
            else if (address < startWriteRegisterAddress + writeRegistersCount && address >= startWriteRegisterAddress)
            {
                return registers[address - startWriteRegisterAddress + readRegistersCount];
            }
            return null;
        }

        public ushort GetRegisterValue(ushort address)
        {
            Register register = GetRegister(address);
            if (register == null)
                return 0;
            else
                return register.registerValue;
        }

        public bool SetRegisterValue(ushort address, ushort value)
        {
            Register register = GetRegister(address);
            if (register == null)
                return false;
            else
                GetRegister(address).registerValue = value;
            return true;
        }
    }
}
