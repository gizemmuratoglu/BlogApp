using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogApp.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}