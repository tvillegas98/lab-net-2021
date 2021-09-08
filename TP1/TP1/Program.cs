using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Omnibus omnibus1 = new Omnibus(10);
            Console.WriteLine(omnibus1.Avanzar());
            Console.WriteLine(omnibus1.Detenerse());

            Taxi taxi1 = new Taxi(10);
            Console.WriteLine(taxi1.Avanzar());
            Console.WriteLine(taxi1.Detenerse());
            Console.ReadLine();
        }
    }
}
