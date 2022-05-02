using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService: IGenericService<Blog>
    {
       
        List<Blog> getListBlog();
        List<Blog> GetBlogListCategory();
        List<Blog> GetBlogListByWriter(int id);
    }
}
