using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWLib.Entity
{
    public class Author
    {
        public int id { get; set; }

        [Display(Name = "Name:")]
        public string name { get; set; }

        [Display(Name = "City:")]
        public string city { get; set; }

        [Display(Name = "Country:")]
        public string country { get; set; }

        public List<Book> books { get; set; }
    }
}
