using System.Collections.Generic;
using System.Web.Http;
using OrbusDevTest.DataAccess.Category;
using OrbusDevTest.DataAccess.Models;

namespace OrbusDevTest.Api
{
    public class CategoryController : ApiController
    {
        ICategoryRepository _repository;

        public CategoryController()
        {
            _repository = Bootstrapper.Resolve<CategoryRepository>();
        }
        // GET api/Category
        public IEnumerable<Category> Get()
        {
            return _repository.GetCategories();
        }

        [ActionName("GetSubCategories")]
        // GET api/Category/GetSubCategories/5
        public IEnumerable<Category> GetSubCategories(int categoryId)
        {
            return _repository.GetSubCategories(categoryId);
        }
    }
}