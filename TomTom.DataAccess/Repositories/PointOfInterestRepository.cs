using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomTom.DataAccess.Contracts;
using TomTom.Domain.Enums;
using TomTom.Domain.Model;

namespace TomTom.DataAccess.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        public void Parse(string fileName)
        {
            throw new NotImplementedException();
        }

        private Record ReadNext(Stream stream)
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

        public int RecordCount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Domain.Model.Record GetRecord(int recordNumber)
        {
            throw new NotImplementedException();
        }
    }
}
