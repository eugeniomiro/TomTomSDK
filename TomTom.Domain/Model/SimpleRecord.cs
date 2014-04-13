using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TomTom.Domain.Model
{
    public class SimpleRecord : Record
    {
        public SimpleRecord(Stream stream)
        {
            _stream = stream;
            using (var reader = new BinaryReader(_stream)) {
                _length = reader.ReadInt32();
                _x      = reader.ReadInt32();
                _y      = reader.ReadInt32();
                //_name   = reader.ReadNullTerminatedString(_length - sizeof(Int32) * 2 - 1);
            }
        }

        private  int      _length;

        protected int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        private  int      _x;

        protected int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private  int      _y;

        protected int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private  string   _name;

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
