using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TomTom.Domain.Enums;

namespace TomTom.Domain.Model
{
    public abstract class Record
    {
        public RecordType Type { get; set; }

        public static Record ReadNext(Stream stream)
        {
            RecordType type = (RecordType) stream.ReadByte();
            switch (type) {
                case RecordType.Deleted:
                    return new DeletedRecord(stream) { Type = type };
                case RecordType.Skipper:
                    return new SkipperRecord(stream) { Type = type };
                case RecordType.Simple:
                    return new SimpleRecord(stream) { Type = type };
                case RecordType.Extended:
                    return new ExtendedRecord(stream) { Type = type };
            }
            return null;
        }
    }
}
