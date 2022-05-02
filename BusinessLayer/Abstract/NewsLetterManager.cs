using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);

            throw new NotImplementedException();
        }

        public void deleteT(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public NewsLetter getById(int id)
        {
            throw new NotImplementedException();
        }

        public NewsLetter getByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> ListAllT(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> ListAllT()
        {
            throw new NotImplementedException();
        }

        public void TAdd(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void updateT(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
