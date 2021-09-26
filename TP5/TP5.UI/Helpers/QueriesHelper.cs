using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;
using TP5.Logic;
using TP5.Logic.DTOClasses;
using TP5.Logic.LogicExtensions;

namespace TP5.UI.Helpers
{
    public static class QueriesHelper
    {
        public static void MostrarCustomers(List<Customers> customers)
        {
            Console.WriteLine($"{"CustomerID", -10}|{"CustomerName", -40}|");
            foreach(Customers customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID,-10}|{customer.CompanyName,-40}|");
            }
            InputHelpers.PresioneUnaTecla();
        }
    
        public static void MostrarListaDeProductos(List<Products> products)
        {
            Console.WriteLine($"{"ProductsName",-40}|{"Stock",-5}|{"UnitPrice",-10}|");
            foreach (Products product in products)
            {
                Console.WriteLine($"{product.ProductName,-40}|{product.UnitsInStock,-5}|{product.UnitPrice,-10}|");
            }
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarProductoConID789(ProductsLogic products, int id)
        {
            Products product = products.Get(id);
            if (product != null)
            {
                Console.WriteLine($"{product.ProductName,-40}|{product.UnitsInStock,-5}|{product.UnitPrice,-10}|");
            }
            else
            {
                Console.WriteLine("No existe ese ID en la base de datos");
            }
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarCostumersDeLaRegionWA(List<Customers> customers)
        {
            Console.WriteLine($"{"CustomerID",-10}|{"CustomerName",-40}|{"Region", -10}|");
            foreach (Customers customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID,-10}|{customer.CompanyName,-40}|{customer.Region, -10}|");
            }
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarCustomersEnMayusculasYMinusculas(List<string> customersName)
        {
            Console.WriteLine($"{"CustomerName", -40}|{"Mayúsculas", -50}|{"Minúsculas", -40}|");
            foreach (string name in customersName)
            {
                Console.WriteLine($"{name, -40}|{name.ToUpper(),-50}|{name.ToLower(),-40}|");
            }
            InputHelpers.PresioneUnaTecla();

        }

        public static void MostrarJoinEntreCustomersYOrdenes(List<CustomersOrdersDTO> customerOrders)
        {
            Console.WriteLine($"{"CustomerID",-15}|{"OrderID",-15}|{"Region",-8}|{"OrderDate",-20}|");
            foreach (CustomersOrdersDTO customersOrder in customerOrders)
            {
                Console.WriteLine($"{customersOrder.CustomerID,-15}|{customersOrder.OrderID,-15}|{customersOrder.Region,-8}|{customersOrder.OrderDate,-20}|");
            }
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarTopTresCustomersDeWA(List<Customers> customers)
        {
            Console.WriteLine($"{"CustomerID",-10}|{"CustomerName",-40}|{"Region",-10}");
            foreach (Customers customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID,-10}|{customer.CompanyName,-40}|{customer.Region,-10}");
            }
            InputHelpers.PresioneUnaTecla();
        }
        
        public static void MostrarLasCategoriasAsociadasAProductos(List<CategoriesProductsDTO> categoriesProducts)
        {
            Console.WriteLine($"{"CategoryID", -15}|{"CategoryName", -20}|");
            foreach (CategoriesProductsDTO category in categoriesProducts)
            {
                Console.WriteLine($"{category.CategoryID, -15}|{category.CategoryName, -20}|");
            }
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarPrimerElementoDeLaListaDeProductos(Products product)
        {
            Console.WriteLine($"El primer producto es la lista de productos es: {product.ProductName} con ID: {product.ProductID}");
            InputHelpers.PresioneUnaTecla();
        }

        public static void MostrarCustomersConCantidadDeOrdenes(Dictionary<string, int> QuantityOfOrders)
        {
            Console.WriteLine($"{"CustomerName", -40}|{"Quantity of Orders", -20}|");
            foreach(KeyValuePair<string, int> customersOrder in QuantityOfOrders)
            {
                Console.WriteLine($"{customersOrder.Key, -40}|{customersOrder.Value, 20}|");
            }
            InputHelpers.PresioneUnaTecla();
        }
    }
}
