using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class DeletedRecord : Record
    {
        public DeletedRecord(Stream stream)
        {
            _stream = stream;

            using (var reader = new BinaryReader(_stream)) {
                _length = reader.ReadInt32();
                _stream.Seek(_length - sizeof(Byte) - sizeof(Int32), SeekOrigin.Current);
            }
        }
        private Int32 _length;
    }
}
