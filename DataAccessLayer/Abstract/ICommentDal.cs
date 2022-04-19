using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment> 
    {
        List<Comment> ListAllComment(int id);
        void CommentAdd(Comment comment);
        void deleteComment(Comment comment);
        void updateComment(Comment comment);
        Comment getById(int id);
    }
}
