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

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Display(Name ="Publication Year")]
        [Required(ErrorMessage ="Publication year is required")]
        public int PubDate { get; set; }

        public string Category { get; set; }

        [Display(Name ="Author")]
        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
