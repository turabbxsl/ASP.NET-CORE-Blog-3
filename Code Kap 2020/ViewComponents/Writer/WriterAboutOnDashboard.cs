using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {

        WriterManager wm = new WriterManager(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var value = wm.GetWriterByID(1);

            return View(value);
        }

    }
}
