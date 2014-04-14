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
            using (var reader = new BinaryReader(stream)) {
                Length = reader.ReadInt32();
                stream.Seek(Length - sizeof(Byte) - sizeof(Int32), SeekOrigin.Current);
            }
        }
        public  Int32 Length { get; set; }
    }
}
