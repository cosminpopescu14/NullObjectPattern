using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class NoDiscount : IDiscount
    {
        public decimal Calculate(decimal orderTotal) => orderTotal;
    }
}
