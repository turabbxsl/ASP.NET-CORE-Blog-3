using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);

            if (values.Count == 0)
            {
                ViewBag.tit = "Bu Bloga Yorum Yapilmamistir.Ilk Yorumu Sen Yap :)";
            }
            return View(values);
        }

    }
}
