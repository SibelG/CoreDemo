﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = cm.getListBlog();
            return View(values);
        }
    }
}
