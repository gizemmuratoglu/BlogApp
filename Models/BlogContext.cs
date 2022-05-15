using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
