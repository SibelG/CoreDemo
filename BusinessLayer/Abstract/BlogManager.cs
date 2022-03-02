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
    public class BlogManager : IBlogServices
    {
        IBlogDal __IblogDal;
        private EfBlogRepository efBlogRepository;

        public BlogManager(EfBlogRepository efBlogRepository)
        {
            this.efBlogRepository = efBlogRepository;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> getListBlog()
        {
            return __IblogDal.GetListAll();
        }
    }
}
