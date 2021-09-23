using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic;
using TP5.Data;
using TP5.Entities;

namespace TP5.UI

{
    class Program
    {
        static void Main(string[] args)
        {
            /*           Func<int, int> square = x => x * x;

                       Func<int, int, int> add = (x, y) => x + y;

                       Console.WriteLine(add(square(2),square(4)));
                       Console.ReadLine();*/
            NorthwindContext context = new NorthwindContext();
/*            var query = from customer in context.Customers
                        orderby customer.CustomerID descending
                        select customer;
            
            foreach(var customer in query)
            {
                Console.WriteLine($"{customer.CustomerID}-{customer.Address}");
            }*/

            var query2 = from product in context.Products
                         where product.UnitsInStock == 0
                         select product;

            foreach (var product in query2)
            {
                Console.WriteLine($"{product.ProductName} : Stock = {product.UnitsInStock}");
            }

            Console.ReadLine();
        }
    }
}
