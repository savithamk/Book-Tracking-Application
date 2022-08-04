using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_Application_Models
{
    public class Book
    {
        [Key]
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [ForeignKey("NameToken")]
        [Display(Name = "Category")]
        public string NameToken { get; set; }
    }
}
