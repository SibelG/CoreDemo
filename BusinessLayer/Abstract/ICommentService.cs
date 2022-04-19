using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentUpdate(Comment comment);
        void CommentDelete(Comment comment);
        Comment getById(int id);
        List<Comment> getListComment(int id);
        List<Comment> GetCommentListCategory();
    }
}
