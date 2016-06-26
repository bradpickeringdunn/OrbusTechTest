using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OAService : IOAService
    {
        AdventureWorksDW2008R2Entities entities;

        public OAService()
        {
            entities = new AdventureWorksDW2008R2Entities();
            entities.Configuration.LazyLoadingEnabled = false;
            entities.Configuration.ProxyCreationEnabled = false;
        }

        public IEnumerable<DimProduct> GetProducts()
        {
            return entities.DimProducts.ToList();
        }

        public DimProduct GetProduct(int productKey)
        {
            return entities.DimProducts.Where(x => x.ProductKey == productKey).FirstOrDefault();
        }

        public int UpdateProduct(DimProduct product)
        {
            var prod = this.GetProduct(product.ProductKey);
            prod.EnglishProductName = product.EnglishProductName;
            prod.SafetyStockLevel = product.SafetyStockLevel;
            return entities.SaveChanges();
        }

        public IEnumerable<DimProductCategory> GetCategories()
        {
            return entities.DimProductCategories;
        }

        public IEnumerable<DimProductSubcategory> GetSubCategories(int productCategoryKey)
        {
            return entities.DimProductSubcategories.Where(x => x.ProductCategoryKey == productCategoryKey);
        }

        public IEnumerable<DimProduct> GetProductsbySubCategoryId(int subCategoryId)
        {
            return entities.DimProducts.Where(x => x.ProductSubcategoryKey == subCategoryId);
        }
    }
}

