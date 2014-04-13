using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class DeletedRecord : Record
    {
        private   System.IO.Stream stream;

        public DeletedRecord(System.IO.Stream stream)
        {
            // TODO: Complete member initialization
            this.stream = stream;
        }
    }
}
