using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAllProductsWithoutStock()
        {
            return (from product in context.Products
                   where product.UnitsInStock == 0
                   select product).ToList();
        }

        public List<Products> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Products Get(int id)
        {
            return context.Products.FirstOrDefault(p => p.ProductID == id);
        }

        public List<Products> GetAllProductsWithStockAndCostMoreThanThree()
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }

        public List<Products> GetAllProductsOrderByName()
        {
            return context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Products> GetAllProductsOrderByUnitsInStock()
        {
            return context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }

    }
}
