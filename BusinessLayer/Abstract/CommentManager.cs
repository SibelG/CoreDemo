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
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;
       

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentListCategory()
        {
            throw new NotImplementedException();
        }

        public List<Comment> getListComment(int id)
        {
            return _commentDal.GetListAll(x=>x.BlogId==id);
        }
    }
}
