using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class WriterManager : IWriterService
    {
        IWriterDal _IwriterDal;

        public WriterManager(IWriterDal writerDal)
        {
            _IwriterDal = writerDal;
        }

        public void deleteT(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer getByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> ListAllT()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public void updateT(Writer t)
        {
            throw new NotImplementedException();
        }

        public void WriterAdd(Writer writer)
        {
            _IwriterDal.Insert(writer);
        }
    }
}
