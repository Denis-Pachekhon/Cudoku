using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    public class Digit : IDigit, ICloneable
    {
        public Digit()  
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }

        public int Value { get; set; }

        public object Clone()
        {
            return new Digit { Value = this.Value};
        }

        public string Display(GridContext gridContext)
        {
            return String.Format("Digit {0}, Id: {1}, " +
                "Column: {2}, Row: {3}", Value, Id, gridContext.Column,
                gridContext.Row) + "\n\r";
        }
        public string Display()
        {
            return Value.ToString() + " ";
        }


    }
}
