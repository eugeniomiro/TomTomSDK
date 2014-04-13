using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTom.DataAccess.Extensions
{
    public static class BinaryReader
    {
        public static String ReadNullTerminatedString(this System.IO.BinaryReader reader, Int32 length)
        {
            String str = String.Empty;
            byte ch;

            do {
                ch = reader.ReadByte();
                if (ch != 0)
                    str += (char) ch;
                length--;
            } while (ch != 0 && length > 0);

            return str;
        }
    }
}
