using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSWLib.Models
{
    public class BookViewModel
    {

        public int Id;

        [Display(Name = "Book Name:")]
        public string name { get; set; }

        [Display(Name = "Description:")]
        public string description { get; set; }

        [Display(Name = "Number of pages:")]
        public int numberOfPages { get; set; }

        [Display(Name = "Category:")]
        public int categoryId { get; set; }

        [Display(Name = "Author:")]
        public int authorId { get; set; }
    }
}