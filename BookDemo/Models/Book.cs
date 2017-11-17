using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemo.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }

      //  [DataType(DataType.Date)]
        [Display(Name ="Publication Date")]
        public int PubDate { get; set; }

        public string Category { get; set; }

        [Display(Name ="Author")]
        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
