using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class CustomersLogic:BaseLogic
    {
        public List<Customers> GetAllCostumers()
        {
            return context.Customers.ToList();
        }

        public List<Customers> GetAllCostumersFromWA()
        {
          return 
                (from customer in context.Customers
                where customer.Region == "WA"
                select customer).ToList();
        }

        public List<string> GetAllCostumersName()
        {
            return (from customer in context.Customers
                   select customer.CompanyName).ToList();
        }

        public List<Customers> TopCustomersFromRegion(string Region, int top)
        {
            return context.Customers.Where(c => c.Region == Region).Take(top).ToList();
        }
    }
}
