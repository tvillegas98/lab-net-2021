using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;
using TP4.UI.Helpers;
namespace TP4.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputHelpers.MostrarTerritorios();
            OutputHelpers.MostrarEmpleados();
            Console.ReadLine();
        }
    }
}
