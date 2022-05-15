using System.Data.Entity;

namespace BlogApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("blogConnection")
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

    }



}
