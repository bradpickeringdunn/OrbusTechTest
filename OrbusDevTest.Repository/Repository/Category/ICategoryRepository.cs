using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrbusDevTest.DataAccess.Category
{
    public interface ICategoryRepository
    {
        IEnumerable<Models.Category> GetCategories();

        IEnumerable<Models.Category> GetSubCategories(int categoryId);
    }
}
