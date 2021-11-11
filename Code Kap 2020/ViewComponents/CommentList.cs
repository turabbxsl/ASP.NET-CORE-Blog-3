using Code_Kap_2020.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Kap_2020.ViewComponents
{
    public class CommentList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
            new UserComment
                {
                    ID = 1,
                    UserName = "Turab"
                },
            new UserComment
                {
                    ID = 2,
                    UserName = "Xeyal"
                },
            new UserComment
                {
                    ID = 3,
                    UserName = "Resid"
                }
            };


            return View(commentvalues);
        }

    }
}
