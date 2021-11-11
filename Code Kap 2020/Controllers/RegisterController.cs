using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Code_Kap_2020.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer writer)
        {

            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Yazici Hakkinda";
                wm.TAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();

        }

    }
}
