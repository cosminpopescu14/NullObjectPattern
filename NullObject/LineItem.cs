using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    class LineItem
    {
        Product p = new Product();
        public Product Product { get; }
        public decimal Quantity { get; }
        public decimal Price => Product.UnitPrice * Quantity;

        public LineItem(Product product, decimal quantity)
        {
            if(quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity));

            if (product == null)
                throw new ArgumentNullException(nameof(product));

            this.Product = product;
            this.Quantity = quantity;
           
        }
    }
}
