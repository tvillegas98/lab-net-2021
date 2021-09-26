using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic;
using TP5.Logic.LogicExtensions;

namespace TP5.UI.Helpers
{
    public static class OperacionesHelper
    {
        public static void determinarOperacion(int opcion, CustomersLogic customers, ProductsLogic products,
            CategoryProductsDTOLogic categoriesProducts, CustomersOrdersDTOLogic customersOrders)
        {
            if (opcion == 1)
            {
                QueriesHelper.MostrarCustomers(customers.GetAllCostumers());

            } else if (opcion == 2)
            {
                QueriesHelper.MostrarListaDeProductos(products.GetAllProductsWithoutStock());

            } else if (opcion == 3)
            {
                QueriesHelper.MostrarListaDeProductos(products.GetAllProductsWithStockAndCostMoreThanThree());

            } else if (opcion == 4)
            {
                QueriesHelper.MostrarCostumersDeLaRegionWA(customers.GetAllCostumersFromWA());

            } else if (opcion == 5)
            {
                QueriesHelper.MostrarProductoConID789(products, 789);

            } else if (opcion == 6)
            {
                QueriesHelper.MostrarCustomersEnMayusculasYMinusculas(customers.GetAllCostumersName());

            } else if (opcion == 7)
            {
                QueriesHelper.MostrarJoinEntreCustomersYOrdenes(customersOrders.CustomersAndOrdersFromWASince("01/01/1997"));

            } else if (opcion == 8)
            {
                QueriesHelper.MostrarTopTresCustomersDeWA(customers.TopCustomersFromRegion("WA", 3));

            } else if (opcion == 9)
            {
                QueriesHelper.MostrarListaDeProductos(products.GetAllProductsOrderByName());

            } else if (opcion == 10)
            {
                QueriesHelper.MostrarListaDeProductos(products.GetAllProductsOrderByUnitsInStock());

            } else if (opcion == 11)
            {
                QueriesHelper.MostrarLasCategoriasAsociadasAProductos(categoriesProducts.GetAllDistinctCategories());

            } else if (opcion == 12)
            {
                QueriesHelper.MostrarPrimerElementoDeLaListaDeProductos(products.GetAllProducts().GetFirstProduct());
            }
            else
            {
                QueriesHelper.MostrarCustomersConCantidadDeOrdenes(customersOrders.CustomerQuatntityOfOrders());
            }
            
        }
    }
}
