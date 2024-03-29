﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_Application_Models
{
    public class Category
    {
        [Key]
        [Required]
        public string NameToken { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [ForeignKey("Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
