﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        
        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogListWithWriter();

        List<Blog> GetBlogListByWriter(int id);

    }
}
