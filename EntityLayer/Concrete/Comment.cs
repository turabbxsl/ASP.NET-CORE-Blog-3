using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {

        [Key]
        public int CommentID { get; set; }

        public string CommentUsername { get; set; }

        public string CommentTitle { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDate { get; set; }

        public int BlogScore { get; set; }

        public bool CommentStatus { get; set; }


        #region Blogla Elaqelendirme
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        #endregion

    }
}
