using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Entities.MyExceptions
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada(string message) : base(message)
        {

        }
    }
}
