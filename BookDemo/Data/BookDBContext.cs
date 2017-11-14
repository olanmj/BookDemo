using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookDemo.Models;

namespace BookDemo.Models
{
    public class BookDBContext : IdentityDbContext<ApplicationUser>
    {
        public BookDBContext (DbContextOptions<BookDBContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        public DbSet<BookDemo.Models.Book> Books { get; set; }
        public DbSet<BookDemo.Models.Author> Authors { get; set; }
        public DbSet<BookDemo.Models.ApplicationUser> ApplicationUser { get; set; }
    }
}
