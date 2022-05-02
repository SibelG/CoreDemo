

using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class BlogManager : IBlogService
    {
      
        private IBlogDal _IblogDal;

        public BlogManager(IBlogDal blogdal)
        {
            _IblogDal = blogdal;
        }

     

        public void BlogUpdate(Blog blog)
        {
            _IblogDal.Update(blog);
        }
        public List<Blog>GetListCategoryByWriter(int id)
        {
            return _IblogDal.GetListByWriterCategory(id);
        }

        public void deleteT(Blog t)
        {
            _IblogDal.Delete(t);
        }

        /* public void BlogAdd(Blog blog)
         {
             _IblogDal.Insert(blog);
         }

         public void BlogDelete(Blog blog)
         {
             _IblogDal.Delete(blog);
         }

         public void BlogUpdate(Blog blog)
         {
             _IblogDal.Update(blog);
         }

         public void deleteT(Blog t)
         {
             _IblogDal.Delete(t);

         }*/

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _IblogDal.GetListAll(x => x.WriterId == id);
            //throw new NotImplementedException();
        }

        public List<Blog> GetBlogListCategory()
        {
            return _IblogDal.GetListCategory();
        }

        public List<Blog> getById(int id)
        {
            return _IblogDal.GetListAll(x => x.BlogId == id);
        }

        public Blog getByIdT(int id)
        {
            return _IblogDal.getById(id);
        }

        public List<Blog> getLastBlog()
        {
            return _IblogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> getListBlog()
        {
            throw new NotImplementedException();
        }

        /* public List<Blog> getListBlog()
         {
             return _IblogDal.GetListAll();
         }*/

      

  
        public void TAdd(Blog t)
        {
            _IblogDal.Insert(t);
        }

        public void updateT(Blog t)
        {
            _IblogDal.Update(t); ;
        }

        public List<Blog> ListAllT()
        {
            return _IblogDal.GetListAll();
        }
    }
}
