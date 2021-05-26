using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    interface IDigit
    {
        Guid Id { get; }
        int Value { get; set; }
        string Display(GridContext gridContext);
    }
}
