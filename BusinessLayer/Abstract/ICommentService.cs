﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {

        void CommentAdd(Comment comment);

        //void CommentDelete(Comment comment);

        //void CommentUpdate(Comment comment);

        List<Comment> GetList(int id);

        //Comment GetByID(int id);






    }
}
