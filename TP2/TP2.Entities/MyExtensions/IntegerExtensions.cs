using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Entities.MyExtensions
{
    public static class IntegerExtensions
    {
        public static int DividirPor(this int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    }
}
