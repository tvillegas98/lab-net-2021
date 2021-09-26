using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Logic.DTOClasses
{
    public class CustomersOrdersDTO
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Region { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
