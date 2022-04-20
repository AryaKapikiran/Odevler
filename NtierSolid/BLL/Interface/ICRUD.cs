using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface ICRUD
    {
        void AddProduct();

        void AddCategory();

        void DeleteProduct();

        void DeleteCategory();

        void UpdateProduct();

        void UpdateCategory();

         List<Category> GetCategoryList();

         List<Product> GetProductList();

    }
}
