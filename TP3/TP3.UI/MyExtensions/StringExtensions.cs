using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.UI.MyExtensions
{
    public static class StringExtensions
    {
        public static string RemoverEspaciosEnBlanco(this string str)
        {
            string[] strSplitted = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", strSplitted);
        }
    }
}
