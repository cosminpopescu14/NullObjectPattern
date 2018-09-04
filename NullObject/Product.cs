using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class Product
    {
        private decimal UnitPice/* = 100*/;

        public decimal UnitPrice
        {
            get
            {
                return this.UnitPice;
            }
            set
            {
                this.UnitPice = value;
            }
        }
    }
}
