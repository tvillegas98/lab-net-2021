using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;

namespace TP4.UI.Helpers
{
    public static class TerritoriesHelper
    {

        const string opcionInvalida = "Opción inválida, intente nuevamente ";
        const string numeroInvalido = "Número no válido, intente nuevamente";
        const string inputRegionID = "Ingrese el ID de una región existente";
        public static void AgregarTerritorio(TerritoriesLogic territorios)
        {
            Console.WriteLine("Ingrese el ID del nuevo territorio");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese la descripción de ese territorio");
            string territoryDescription = Console.ReadLine();
            int idRegion = InputHelpers.ObtenerNumero(inputRegionID, numeroInvalido);

            Territories territory = new Territories()
            {
                TerritoryID = id,
                TerritoryDescription = territoryDescription,
                RegionID = idRegion
            };
            try
            {
                territorios.Add(territory);
                Console.WriteLine("¡Insertado el nuevo territorio en la base de datos con exito!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}\nStackTrace:{error.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Presione alguna tecla para continuar...");
                Console.ReadLine();
            }

        }
        public static void EliminarTerritorio(TerritoriesLogic territorios)
        {
            Console.WriteLine("Ingrese el ID del nuevo territorio");
            string id = Console.ReadLine();
            try
            {
                territorios.Delete(id);
                Console.WriteLine("¡Se ha eliminado el territorio en la base de datos con exito!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}\nStackTrace:{error.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Presione alguna tecla para continuar...");
                Console.ReadLine();
            }
        }

        public static void ActualizarTerritorio(TerritoriesLogic territorios)
        {
            Console.WriteLine("Ingrese el ID del nuevo territorio");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva descripción de ese territorio");
            string territoryDescription = Console.ReadLine();
            int idRegion = InputHelpers.ObtenerNumero(inputRegionID, numeroInvalido);
            Territories territory = new Territories()
            {
                TerritoryID = id,
                TerritoryDescription = territoryDescription,
                RegionID = idRegion
            };

            try
            {
                territorios.Update(territory);
                Console.WriteLine("¡Se han actualizado los datos en la base de datos con exito!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}\nStackTrace:{error.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Presione alguna tecla para continuar...");
                Console.ReadLine();
            }
        }
    }
}
