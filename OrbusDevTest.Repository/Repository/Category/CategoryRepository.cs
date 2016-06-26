using System;
using System.Collections.Generic;

namespace OrbusDevTest.DataAccess.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        // TODO: Include OAService, this will allow you to query the webservice

        /*
         * Example of Mapping Between DimProductCategory (OAService) <-> Category (Client Model)
         * 
         * ProductCategoryKey <-> Id,
         * EnglishProductCategoryName <-> Name
         * 
         * 
         * 
         * Example of Mapping Between DimProductSubcategory (OAService) <-> Category (Client Model)
         * 
         * ProductSubcategoryKey <-> Id,
         * EnglishProductSubcategoryName <-> Name
         * 
         * 
         * Don't spend time implementing a 3rd part mapping framework, but try to use Linq if you can
         */

        public IEnumerable<Models.Category> GetCategories()
        {
            // TODO: Get categories from OAService and map (see mapping above) to the Category client Model
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Category> GetSubCategories(int categoryId)
        {
            // TODO: Get sub categories by category id from OAService and map (see mapping above) to the Category client Model (OAService Method: GetSubCategories)
            throw new NotImplementedException();
        }
    }
}