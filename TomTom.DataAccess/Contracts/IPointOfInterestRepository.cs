using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomTom.Domain.Model;

namespace TomTom.DataAccess.Contracts
{
    public interface IPointOfInterestRepository
    {
        void Parse(String fileName);
        int RecordCount { get; set; }
        Record GetRecord(int recordNumber);
    }
}
