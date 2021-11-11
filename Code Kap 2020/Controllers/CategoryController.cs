using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());


        public IActionResult Index()
        {
            var values = categoryManager.GetList();

            return View(values);
        }
    }
}
