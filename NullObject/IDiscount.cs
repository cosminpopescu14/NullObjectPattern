using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    interface IDiscount
    {
        decimal Calculate(decimal orderTotal);
    }
}
