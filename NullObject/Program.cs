using System;

namespace NullObject
{
    class Program
    {
        // the project uses net core 2.0
        static void Main(string[] args)
        {
            //forgot to add discount
            var product1 = new Product();
            var product2 = new Product();
            var order = new Order();
            order.AddLineItem(new LineItem(product1, 2));
            order.AddLineItem(new LineItem(product2, 1));


            Console.WriteLine($"Total: {order.Total}");
            Console.ReadLine();
        }
    }
}
