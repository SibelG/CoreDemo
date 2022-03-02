using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public void categoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void deleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            throw new NotImplementedException();
        }

        public void updateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
