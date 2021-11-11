using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {

        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();

            return View(values);
        }
    }
}
