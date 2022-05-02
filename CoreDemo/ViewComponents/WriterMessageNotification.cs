﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class WriterMessageNotification:ViewComponent
    {
        WriterManager cm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
           
            return View();

        }
    }
}
