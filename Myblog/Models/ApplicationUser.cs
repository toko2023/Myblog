using Microsoft.AspNetCore.Identity;

namespace Myblog.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FristName { get; set; }
        public  string? LastName { get; set; }
        // relation
        public List<Post>? Posts { get; set; }
    }
}
