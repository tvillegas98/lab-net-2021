using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic.LogicExtensions
{
    public static class CustomersExtension
    {
        public static Customers GetFirstCostumer(this List<Customers> customers)
        {
            return customers.FirstOrDefault();
        }
    }
}
