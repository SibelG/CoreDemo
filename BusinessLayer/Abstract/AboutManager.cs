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

        public AboutManager(IAboutDal ıAboutDal)
        {
            _IAboutDal = ıAboutDal;
        }

        public List<About> GetList()
        {
            return _IAboutDal.GetListAll();
        }
    }
}
