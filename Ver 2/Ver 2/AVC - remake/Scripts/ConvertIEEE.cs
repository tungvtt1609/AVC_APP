using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC___remake.Scripts
{
    public static class ConvertIEEE
    {
        public static float ToSingle(ushort Lo, ushort Hi)
        {
            float floatReturn;
            byte[] b = BitConverter.GetBytes(Hi << 16 | Lo);
            if (!BitConverter.IsLittleEndian)
            {
                b = b.Reverse().ToArray();
            }
            floatReturn = BitConverter.ToSingle(b, 0);
            return floatReturn;
        }
    }
}
