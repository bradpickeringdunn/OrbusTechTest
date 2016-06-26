using System.Collections.Generic;
using OrbusDevTest.DataAccess.Models;

namespace OrbusDevTest.DataAccess
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        bool UpdateProduct(Product product);

        IEnumerable<Product> GetProductsBySubCateogoryId(int subCategoryId);
    }
}
