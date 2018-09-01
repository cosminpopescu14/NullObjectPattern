using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class FrequentBuyerDiscount : IDiscount
    {
        public decimal Calculate(decimal rate = (decimal)0.3)
        {
            return rate;
        }
    }
}
