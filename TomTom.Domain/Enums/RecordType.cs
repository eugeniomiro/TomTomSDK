using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTom.Domain.Enums
{
    public enum RecordType : byte
    {
        Deleted     = 0,
        Skipper     = 1,
        Simple      = 2,
        Extended    = 3
    }
}
