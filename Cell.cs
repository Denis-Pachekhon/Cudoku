using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    public class Cell : ICloneable
    {
        public Digit Digit { get; private set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public Cell(Digit digit)
        {
            Digit = digit;
        }
        public object Clone()
        {
            return new Cell((Digit)Digit.Clone()) { Row = this.Row, Column = this.Column};
        }
    }
}
