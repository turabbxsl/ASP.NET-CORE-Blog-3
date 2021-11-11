using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EFBlogRepository());
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());


        Context c = new Context();

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();

            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;

            var values = bm.GetBlogByID(id);

            return View(values);

        }


        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBM(1);

            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EFCategoryRepository());
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }
                                               ).ToList();

            ViewBag.categories = categories;

            return View();
        }


        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator wv = new BlogValidator();
            ValidationResult result = wv.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;

                bm.TAdd(blog);

                return RedirectToAction("BlogListByWriter", "Blog");
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
            var blogvalue = bm.TGetByID(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }


        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.TGetByID(id);
            
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }
                                               ).ToList();

            ViewBag.cv = categories;

            return View(blogvalue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            blog.WriterID = 1;
            blog.BlogCreateDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogStatus = true;

            bm.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }


    }
}
