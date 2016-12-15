namespace MVCBlog.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }
        //[Required]
        //public int Id { get; set; }

        //[Required]
        //public string Text { get; set; }
        //[Required]
        //public int PostID { get; set; }

        //public int? AuthorID { get; set; }

        //[StringLength(100)]
        //public string AuthorName { get; set; }
        //[Required]
        //public DateTime Date { get; set; }

        //public virtual Post Post { get; set; }

        //public virtual ApplicationUser Author { get; set; }

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
        [Required]
        public int PostID { get; set; }

        public string Author_Id { get; set; }
    
        [ForeignKey("Author_Id")]
        public Comments Author { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual Post Post { get; set; }



    }
}
