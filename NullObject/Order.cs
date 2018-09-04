using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace NullObject
{
    class Order
    {

        public IEnumerable<LineItem> LineItems => lineItems.AsReadOnly();
        public decimal Total => discount.Calculate(totalBeforeDiscount); // error if the dicount is null. null could be checked with:
                                                                         // discount == null ? totalBeforeDiscount : discount.Calculate(totalBeforeDiscount);
        private decimal totalBeforeDiscount => lineItems.Sum(i => i.Price);

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
