using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {

        public IViewComponentResult Invoke(int id)
        {           
            return View();
        }

    }
}
