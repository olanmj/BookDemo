using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookDemo.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext (DbContextOptions<BookDBContext> options)
            : base(options)
        {
        }

        public DbSet<BookDemo.Models.Book> Books { get; set; }
        public DbSet<BookDemo.Models.Author> Authors { get; set; }
    }
}
