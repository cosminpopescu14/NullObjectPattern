using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class CouponDiscount : IDiscount
    {
        private string couponCode;
        private float rate;

        //maybe add props
        
        public CouponDiscount()
        {

        }

        public CouponDiscount(string _couponCode, float _rate)
        {
            this.couponCode = _couponCode;
            this.rate = _rate;
        }

        public decimal Calculate(decimal orderTotal)
        {
            return orderTotal * (decimal)rate;
        }
    }
}
