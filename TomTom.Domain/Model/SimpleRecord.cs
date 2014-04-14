using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class SimpleRecord : Record
    {
        public SimpleRecord(Stream stream)
        {
            using (var reader = new BinaryReader(stream)) {
                Length  = reader.ReadInt32();
                X       = reader.ReadInt32();
                Y       = reader.ReadInt32();
                //Name   = reader.ReadNullTerminatedString(_length - sizeof(Int32) * 2 - 1);
            }
        }

        public  int     Length  { get; set; }
        public  int     X       { get; set; }
        public  int     Y       { get; set; }
        public  string  Name    { get; set; }
    }
}
