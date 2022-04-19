using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager mn = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult AddSubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddSubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            mn.AddNewsLetter(p);
            return PartialView();
        }
    }
}
