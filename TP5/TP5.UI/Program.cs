using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic;
using TP5.UI.Helpers;

namespace TP5.UI

{
    class Program
    {
        const string menu =
            "1. Query para obtener todos los customers\n" +
            "2. Query para obtener todos los productos sin stock\n" +
            "3. Query para obtener todos los productos con stock y que cuestan mas de 3$\n" +
            "4. Query para devolver todos customers de la region WA\n" +
            "5. Query para devolver el primer elemento o nulo de la lista de productos donde el ID del producto es 789\n" +
            "6. Query para obtener el nombre de los customers en mayúsculas y minúsculas\n" +
            "7. Query para devolver los costumers de la región WA que poseean ordenes después de o en 1/1/1997\n" +
            "8. Query para devolver los 3 customers de la region WA\n" +
            "9. Query para devolver la lista de productos ordenados por nombre\n" +
            "10. Query para devolver lista de productos ordenados por UnitsInStock de mayor a menor\n" +
            "11. Query para devolver las distintas categorías asociadas a productos\n" +
            "12. Query para devolver el primer elemento de una lista de producos\n" +
            "13. Query para devolver los costumer con cantidad de ordenes asociadas\n" +
            "14. Cerrar Programa\n" +
            "Ingrese una opción: ";

        const string opcionInvalida = "Opción inválida, intente nuevamente";
        const int minOpciones = 1;
        const int maxOpciones = 14;
        static void Main(string[] args)
        {

            CustomersLogic customers = new CustomersLogic();
            ProductsLogic products = new ProductsLogic();
            CategoryProductsDTOLogic categoryProductsLogic = new CategoryProductsDTOLogic();
            CustomersOrdersDTOLogic customersOrdersLogic = new CustomersOrdersDTOLogic();
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                Console.Clear();
                int opcion = InputHelpers.ObtenerNumero(menu, opcionInvalida, minOpciones, maxOpciones);
                if (opcion == maxOpciones) cerrarMenu = true;
                else
                {
                    Console.Clear();
                    OperacionesHelper.determinarOperacion(opcion, customers, products, categoryProductsLogic, customersOrdersLogic);
                }
            }
        }
    }
}
