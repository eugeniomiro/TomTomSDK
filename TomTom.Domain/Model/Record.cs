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
    }
}
