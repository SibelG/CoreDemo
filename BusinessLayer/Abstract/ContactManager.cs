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
    public class ContactManager : IContactService
    {
        IContactDal _IcontactDal;

        public ContactManager(IContactDal ıcontactDal)
        {
            _IcontactDal = ıcontactDal;
        }

        public void ContactAdd(Contact p)
        {
            _IcontactDal.Insert(p);
        }
    }
}
