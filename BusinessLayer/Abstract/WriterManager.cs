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

        public void WriterAdd(Writer writer)
        {
            _IwriterDal.Insert(writer);
        }
    }
}
