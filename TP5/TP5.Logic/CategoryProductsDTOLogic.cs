using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Logic.DTOClasses;

namespace TP5.Logic
{
    public class CategoryProductsDTOLogic : BaseLogic
    {
        public List<CategoriesProductsDTO> GetAllDistinctCategories()
        {
            return (context.Products.Join(
                            context.Categories, 
                            p => p.CategoryID,
                            c => c.CategoryID,
                            (p, c) => new CategoriesProductsDTO
                            {
                                CategoryID = c.CategoryID,
                                CategoryName = c.CategoryName,
                                ProductID = p.ProductID,
                                ProductName = p.ProductName
                            }
                            ).GroupBy(cp => cp.CategoryName).Select(cp => cp.FirstOrDefault())).ToList();
        }
    }
}
