﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void deleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListAllComment(int id)
        {
            throw new NotImplementedException();
        }

      

        public void updateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
