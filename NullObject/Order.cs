using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class Order
    {
        public int totalBeforeDiscount = 300;
        public IEnumerable<LineItem> LineItems => lineItems.AsReadOnly();
        public decimal Total => discount.Calculate(totalBeforeDiscount); // error if the dicount is null. null could be checked with:
                                                                         // discount == null ? totalBeforeDiscount : discount.Calculate(totalBeforeDiscount);

        private IDiscount discount;
        private List<LineItem> lineItems; //initialized to null

        public Order()
        {
            lineItems = new List<LineItem>();
            discount = new NoDiscount(); //this is the null object. initial value for discount
        }

        public void AddLineItem(LineItem lineItem)
        {
            //no need to check if lineItem is null because is initialized in class constructor
            /*if (lineItem == null)
                throw new ArgumentNullException(nameof(lineItem));*/

            lineItems.Add(lineItem);
        }

        public void AddDiscount(IDiscount discount)
        {
            if (discount == null)
                throw new ArgumentNullException(nameof(discount));

            this.discount = discount;
        }
    }
}
