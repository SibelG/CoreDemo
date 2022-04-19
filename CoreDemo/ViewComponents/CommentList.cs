using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<Comment>
            {
                new Comment
                {
                    BlogId=1,
                    CommentUserName="Melis"
                },
                 new Comment
                {
                    BlogId=2,
                    CommentUserName="Mehmet"
                },
                  new Comment
                {
                    BlogId=3,
                    CommentUserName="Arya"
                },
            };
            return View(commentValues);

        }
    }
}
