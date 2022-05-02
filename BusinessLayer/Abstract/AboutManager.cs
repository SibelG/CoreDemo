using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class AboutManager : IAboutService
    {
        IAboutDal _IAboutDal;

        public AboutManager(IAboutDal IAboutDal)
        {
            _IAboutDal = IAboutDal;
        }

        public void deleteT(About t)
        {
            _IAboutDal.Delete(t);
        }

        public About getByIdT(int id)
        {
            return _IAboutDal.getById(id);
        }

        public List<About> GetList()
        {
             return _IAboutDal.GetListAll();
        }

        public List<About> ListAllT()
        {
            return _IAboutDal.GetListAll();
        }

        public void TAdd(About t)
        {
            _IAboutDal.Insert(t);
        }

        public void updateT(About t)
        {
             _IAboutDal.Update(t);
        }
    }
}
