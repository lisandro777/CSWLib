using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSWLib.Api.Models
{
    public class BookViewModel
    {
        public int id { get; set; }

        [Display(Name = "Book Name:")]
        public string name { get; set; }

        [Display(Name = "Description:")]
        public string description { get; set; }

        [Display(Name = "Number of pages:")]
        public int numberOfPages { get; set; }

        public int categoryId { get; set; }

        public string category { get; set; }

        public int authorId { get; set; }

        public string author { get; set; }
    }
}