using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        
        public void categoryAdd(Category category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void deleteCategory(Category category)
        {
            using var c = new Context();
            c.Remove(category);
            c.SaveChanges();
        }

        public Category getById(int id)
        {
            using var c = new Context();
            return c.Categories.Find(id);

        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            using var c = new Context();
            return c.Categories.ToList();
           
            
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void updateCategory(Category category)
        {
            using var c = new Context();
            c.Update(category);
            c.SaveChanges();
        }
    }
}
