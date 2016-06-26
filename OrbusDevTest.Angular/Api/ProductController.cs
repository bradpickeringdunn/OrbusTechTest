using System;
using System.Collections.Generic;
using System.Web.Http;
using OrbusDevTest.DataAccess;
using OrbusDevTest.DataAccess.Models;

namespace OrbusDevTest.Angular.Api
{
    public class ProductController : ApiController
    {
        IProductRepository _repository;

        public ProductController()
        {
            _repository = new ProductRepository();
        }

        // GET api/Product/GetProductListBySubCategory/3
        public IEnumerable<Product> GetProductListBySubCategory(int id)
        {
            // TODO: Get filtered products list
            throw new NotImplementedException();
        }

        [HttpPost]
        public Product Edit(Product product)
        {
            // TODO: Update product to WebService
            throw new NotImplementedException();
        }
    }
}