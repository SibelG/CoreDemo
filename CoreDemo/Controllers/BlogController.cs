using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());
        CategoryManager cmGetCategory = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetBlogListCategory();
            return View(values);
        }
        public IActionResult AllReadBlog(int id)
        {
            ViewBag.i = id;
            var values = cm.getByIdT(id);
            return View(values);
        }
        public IActionResult GetListByWriter(int id)
        {
            var deger=cm.GetBlogListByWriter(id);
            return View(deger);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            List<SelectListItem> categoryValues = (from x in cmGetCategory.ListAllT()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidation validation = new BlogValidation();
            ValidationResult result = validation.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus=true;
                p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                cm.TAdd(p);
                return RedirectToAction("GetListByWriter", "Blog");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogValue = cm.getByIdT(id);
            cm.deleteT(blogValue);
            return RedirectToAction("GetListByWriter","Blog");
            
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = cm.getByIdT(id);
            List<SelectListItem> categoryValues = (from x in cmGetCategory.ListAllT()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(blogValue);

        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            cm.updateT(p);
            return RedirectToAction("GetListByWriter","Blog");

        }


    }
}
