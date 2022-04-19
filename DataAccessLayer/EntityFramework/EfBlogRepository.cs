using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void deleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListCategory()
        {
           using(var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> ListAllBlog()
        {
            throw new NotImplementedException();
        }

        public void updateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
