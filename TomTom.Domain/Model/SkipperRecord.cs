using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class SkipperRecord : Record
    {
        private   System.IO.Stream stream;

        public SkipperRecord(System.IO.Stream stream)
        {
            // TODO: Complete member initialization
            this.stream = stream;
        }
    }
}
