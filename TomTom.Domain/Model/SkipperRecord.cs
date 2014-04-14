using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class SkipperRecord : Record
    {
        public SkipperRecord(Stream stream)
        {
            using(var reader = new BinaryReader(stream)) {
                BytesInFile = reader.ReadInt32();
                X1 = reader.ReadInt32();
                Y1 = reader.ReadInt32();
                X2 = reader.ReadInt32();
                Y2 = reader.ReadInt32();
            }
        }
        public  int BytesInFile { get; set; }
        public  int X1          { get; set; }
        public  int Y1          { get; set; }
        public  int X2          { get; set; }
        public  int Y2          { get; set; }
    }
}
