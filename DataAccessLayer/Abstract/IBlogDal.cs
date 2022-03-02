using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> ListAllBlog();
        void BlogAdd(Blog blog);
        void deleteBlog(Blog blog);
        void updateBlog(Blog blog);
        Blog getById(int id);
    }
}
