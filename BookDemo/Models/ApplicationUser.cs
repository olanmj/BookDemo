using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ScreenName { get; set; }
    }
}
