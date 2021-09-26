using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic.DTOClasses;

namespace TP5.Logic
{
    public class CustomersOrdersDTOLogic:BaseLogic 
    {
        public List<CustomersOrdersDTO> CustomersAndOrdersFromWASince(string dateString)
        {
            DateTime date = Convert.ToDateTime(dateString);
            return (from customer in context.Customers
                   join order in context.Orders
                   on customer.CustomerID equals order.CustomerID 
                   where customer.Region == "WA" && DbFunctions.TruncateTime(order.OrderDate) >= date
                   select new CustomersOrdersDTO
                   {
                       OrderID = order.OrderID,
                       CustomerID = customer.CustomerID,
                       Region = customer.Region,
                       OrderDate = (DateTime)order.OrderDate
                   }).ToList();
        }

        public Dictionary<string, int> CustomerQuatntityOfOrders()
        {
            return context.Customers.Join
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
                            .Select(co => new { CustomerName = co.Key, Orders = co.Count() })
                            .ToDictionary(co => co.CustomerName, co => co.Orders);
        }
    }
}
