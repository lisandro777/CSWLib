using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWLib.Entity
{
    public class Category
    {
        public int id { get; set; }

        [Display(Name = "Category:")]
        public string name { get; set; }

        [Display(Name = "Descripcion:")]
        public string description { get; set; }
        
    }
}
