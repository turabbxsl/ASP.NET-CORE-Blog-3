using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {

        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory().OrderByDescending(x=>x.BlogCreateDate).Take(10).ToList();

            return View(values);
        }





    }
}
