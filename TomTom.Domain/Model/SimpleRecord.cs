using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    class SimpleRecord : Record
    {
        private   System.IO.Stream stream;

        public SimpleRecord(System.IO.Stream stream)
        {
            // TODO: Complete member initialization
            this.stream = stream;
        }
    }
}
