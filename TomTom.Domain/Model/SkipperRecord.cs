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
            _stream = stream;
            using(var reader = new BinaryReader(stream)) {
                _bytesInFile = reader.ReadInt32();
                _x1 = reader.ReadInt32();
                _y1 = reader.ReadInt32();
                _x2 = reader.ReadInt32();
                _y2 = reader.ReadInt32();
            }
        }
        private  int _bytesInFile;
        private  int _x1;
        private  int _y1;
        private  int _x2;
        private  int _y2;
    }
}
