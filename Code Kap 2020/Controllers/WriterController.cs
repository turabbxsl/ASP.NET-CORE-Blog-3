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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{

    public class WriterController : Controller
    {

        WriterManager wm = new WriterManager(new EFWriterRepository());

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult WriterProfile()
        {
            return View();
        }

   
        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writervalues = wm.GetByID(1);

            return View(writervalues);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator wv = new WriterValidator();

            ValidationResult results = wv.Validate(writer);

            if (results.IsValid)
            {
                wm.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View(writer);
        }



        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();

            if (p != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImagename = Guid.NewGuid() + extension;

                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/",newImagename);
                var stream = new FileStream(location,FileMode.Create);

                p.WriterImage.CopyTo(stream);
                w.WriterImage = newImagename;
            }

            w.WriterMail = p.WriterMail;
            w.WriterName= p.WriterName;
            w.WriterPassword= p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;

            wm.TAdd(w);

            return RedirectToAction("Index", "Dashboard");
        }










    }
}
