using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic;
using TP5.Data;
using TP5.Entities;
using System.Data.Entity;

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
            context.Database.Log = Console.WriteLine;
            /*            var query = from customer in context.Customers
                                    orderby customer.CustomerID descending
                                    select customer;

                        foreach(var customer in query)
                        {
                            Console.WriteLine($"{customer.CustomerID}-{customer.Address}");
                        }*/

            /*            var query2 = from product in context.Products
                                     where product.UnitsInStock == 0
                                     select product;

                        foreach (var product in query2)
                        {
                            Console.WriteLine($"{product.ProductName} : Stock = {product.UnitsInStock}");
                        }*/


            /*            var query3 = from product in context.Products
                                     where product.UnitsInStock != 0 && product.UnitPrice > 3
                                     select product;
                        foreach (Products product in query3)
                        {
                            Console.WriteLine($"{product.ProductID}-{product.ProductName}-{product.UnitsInStock}:{product.UnitPrice:F1}$");
                        }*/


            /*            var query4 = from customer in context.Customers
                                     where customer.Region == "WA"
                                     select customer;

                        Console.WriteLine($"{"Nombre de Compañía",-50}|{"Nombre del Contacto", 30}|{"Region",30}|");
                        foreach (Customers customer in query4)
                        {
                            Console.WriteLine($"{customer.CompanyName, -50}|{customer.ContactName,30}|{customer.Region, 30}|");
                        }*/

            /*            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);
                        Console.WriteLine($" {(query5 is null? true:false)}");*/
            /*
                        Console.WriteLine($"{"Nombre en mayúsculas", -50}|{"Nombre en minúsculas", 50}|");
                        var query6 = from customer in context.Customers
                                 select customer;

                        foreach (Customers customer in query6)
                        {
                            Console.WriteLine($"{customer.CompanyName.ToUpper(), -50}|{customer.CompanyName.ToLower(), 50}|");
                        }*/
            /*            DateTime inicio = Convert.ToDateTime("1/1/1997");
                        var query7 = from customer in context.Customers
                                     join order in context.Orders
                                     on new { customer.CustomerID }
                                        equals new { order.CustomerID }
                                     where customer.Region == "WA" && DbFunctions.TruncateTime(order.OrderDate) >= inicio
                                     select new
                                     {
                                         CustomerID = customer.CustomerID,
                                         OrderID = order.OrderID,
                                         CustomerName = customer.CompanyName,
                                         Region = customer.Region,
                                         OrderDate = order.OrderDate
                                     };

                        Console.WriteLine($"{"CustomerID", -15}|{"OrderID", -15}|{"CustomerName",-35}|{"Region", -8}|{"OrderDate", -20}|");
                        foreach (var item  in query7)
                        {
                            Console.WriteLine($"{item.CustomerID, -15}|{item.OrderID, -15}|{item.CustomerName,-35}|{item.Region,-8}|{item.OrderDate,-20}|");
                        }
            */

            /*            var query8 = context.Customers.Where(c => c.Region == "WA").Take(3);
                        foreach (var customer in query8)
                        {
                            Console.WriteLine($"{customer.CustomerID, -10}|{customer.CompanyName, -35}|{customer.Region, -10}");
                        }*/

            /*            var query9 = context.Products.OrderBy(p => p.ProductName);
                        Console.WriteLine($"{"Numero",-10}{"ProductID",-15}|{"ProductName",-30}|");
                        int counter = 1;
                        foreach (var product in query9)
                        {
                            Console.WriteLine($"{counter}|{product.ProductID, -15}|{product.ProductName, -30}|");
                            counter++;
                        }
                        Console.WriteLine($"{query9.Count()}");
                        */

            /*            var query10 = context.Products.OrderByDescending(p => p.UnitsInStock);
                        Console.WriteLine($"{"ProductID",-10}|{"ProductName",-35}|{"UnitsInStock",-20}");
                        foreach (var item in query10)
                        {
                            Console.WriteLine($"{item.ProductID, -10}|{item.ProductName, -35}|{item.UnitsInStock, -20}");
                        }
                        Console.ReadLine();*/

            /*            var query11 = context.Products.Join(
                            context.Categories,
                            p => p.CategoryID,
                            c => c.CategoryID,
                            (p, c) => new
                            {
                                c.CategoryName
                            }
                            ).Distinct();
                        foreach (var item in query11)
                        {
                            Console.WriteLine($"{item.CategoryName}");
                        }*/


            /*            var query12 = context.Products.Take(1);
                        foreach (var item in query12)
                        {
                            Console.WriteLine($"{item.ProductName}");
                        }
                        Console.ReadLine();*/

            var query13 = context.Customers.Join
                (
                context.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new
                {
                    CustomerName = c.CompanyName,
                    OrderID = o.OrderID
                }
                ).GroupBy(c => c.CustomerName)
                .Select(co => new { CustomerName = co.Key, Orders = co.Count()});
            foreach (var item in query13)
            {
                Console.WriteLine($"{item.CustomerName},{item.Orders}");
            }
            Console.ReadLine();
        }
    }
}
