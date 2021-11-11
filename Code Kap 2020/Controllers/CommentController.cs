using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager(new EFCommentRepository());


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;
            cm.CommentAdd(comment);

            return PartialView();
        }

        public JsonResult Insert(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;
            cm.CommentAdd(comment);
            return Json("Eklendi");
        }





        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);

            return PartialView(values);
        }


    }
}
