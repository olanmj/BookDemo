using Microsoft.AspNetCore.Identity;

namespace BookDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ScreenName { get; set; }
    }
}