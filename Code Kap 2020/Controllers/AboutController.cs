using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EFAboutRepository());

        public IActionResult Index()
        {
            var values = am.GetList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }






    }
}
