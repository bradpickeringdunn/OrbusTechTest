using System.Collections.Generic;
using System.Web.Http;
using OrbusDevTest.DataAccess.Category;
using OrbusDevTest.DataAccess.Models;

namespace OrbusDevTest.Angular.Api
{
    public class CategoryController : ApiController
    {
        ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        // GET api/Category
        public IEnumerable<Category> Get()
        {
            return _repository.GetCategories();
        }

        // GET api/Category/GetSubCategories/5
        public IEnumerable<Category> GetSubCategories(int id)
        {
            return _repository.GetSubCategories(id);
        }
    }
}