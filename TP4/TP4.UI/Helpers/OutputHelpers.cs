using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;
using TP4.UI.MyExtensions;

namespace TP4.UI.Helpers
{
    public class OutputHelpers
    {
        public static void MostrarTerritorios()
        {
            TerritoriesLogic territories = new TerritoriesLogic();
            Console.Write($"{"TerritoryID",-10}|{"TerritoryDescription"}|\n");
            foreach (Territories territory in territories.GetAll())
            {
                Console.WriteLine($"{territory.TerritoryID,-11}|{territory.TerritoryDescription.RemoverEspaciosEnBlanco(),20}|");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
            
        public static void MostrarEmpleados()
        {
            EmployeesLogic employees = new EmployeesLogic();
            Console.Write($"{"EmployeeID",-10}|{"First Name",15}|{"Last Name", 15}|\n");
            foreach (Employees employee in employees.GetAll())
            {
                Console.WriteLine($"{employee.EmployeeID, -10}|{employee.FirstName, 15}|{employee.LastName, 15}|");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MostrarRegiones()
        {
            RegionLogic regions = new RegionLogic();
            Console.Write($"{"RegionID",-10}|{"RegionDescription",15}|\n");
            foreach (Region region in regions.GetAll())
            {
                Console.WriteLine($"{region.RegionID,-10}|{region.RegionDescription.RemoverEspaciosEnBlanco(),17}|");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
