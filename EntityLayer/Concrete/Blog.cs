﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
   public class Blog
    {

        [Key]
        public int BlogID { get; set; }

        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string BlogThumbnailImage { get; set; }

        public string BlogImage { get; set; }

        public DateTime BlogCreateDate { get; set; }

        public bool BlogStatus { get; set; }

        public List<Comment> Comments { get; set; }


        #region Categoriya ile Elaqelendirme
        public int CategoryID { get; set; }
        public Category Category{ get; set; }
        #endregion

        #region Writer ile Elaqelendirme
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
        #endregion





    }
}
