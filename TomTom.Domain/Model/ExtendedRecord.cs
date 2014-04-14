using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class ExtendedRecord : SimpleRecord
    {
        public ExtendedRecord(Stream stream)
            : base(stream)
        {
            using (var reader = new BinaryReader(stream)) {
                
            }
        }
        public Guid Id { get; set; }
    }
}
