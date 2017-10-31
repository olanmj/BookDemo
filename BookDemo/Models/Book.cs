using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemo.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public DateTime PubDate { get; set; }

        public string Category { get; set; }

        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
