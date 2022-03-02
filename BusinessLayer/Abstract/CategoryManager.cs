using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
      
        GenericRepository<Category> repository = new GenericRepository<Category>();
        //CategoryRepository repository = new CategoryRepository();
        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
           

            
        }

        public void CategoryDelete(Category category)
        {
            if(category.CategoryId != 0)
            {
                _categoryDal.Delete(category);
            }
            
        }

        public void CategoryUpdate(Category category)
        {
           _categoryDal.Update(category);
        }

        public Category getById(int id)
        {
            return _categoryDal.getById(id);
        }

        public List<Category> getListCategory()
        {
            return _categoryDal.GetListAll();
        }
    }
}
