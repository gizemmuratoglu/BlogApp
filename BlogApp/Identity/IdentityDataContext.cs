using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogApp.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("blogConnection")
        {


        }

    }
}