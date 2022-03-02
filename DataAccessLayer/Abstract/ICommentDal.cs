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
        List<Comment> ListAllComment();
        void CommentAdd(Blog blog);
        void deleteComment(Blog blog);
        void updateComment(Blog blog);
        Comment getById(int id);
    }
}
