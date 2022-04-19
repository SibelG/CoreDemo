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

        public void BlogAdd(Blog blog)
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

        public List<Blog> getListBlog()
        {
            return _IblogDal.GetListAll();
        }

        Blog IBlogService.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
