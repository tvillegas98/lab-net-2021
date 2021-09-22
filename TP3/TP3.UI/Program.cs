using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Entities;
using TP3.Logic;

namespace TP3.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            TerritoriesLogic territories = new TerritoriesLogic();
            foreach(Territories territory in territories.GetAll())
            {
                Console.WriteLine($"{territory.TerritoryID}-{territory.TerritoryDescription}");
            }
            Console.ReadLine();
        }
    }
}
