using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer: DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="Technology"},
                new Category(){CategoryName="Sport"},
                new Category(){CategoryName="War"},

            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Post> posts = new List<Post>() {
                new Post()
                {
                    Title = "LOREM",
                    Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    CategoryId=1,
                    Date= DateTime.Now
                  
                },
                  new Post()
                {
                    Title = "LOREM",
                    Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    CategoryId=2,
                    Date= DateTime.Now,
                },
                    new Post()
                {
                    Title = "LOREMMM",
                    Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    CategoryId=1,
                    Date= DateTime.Now.AddDays(-5),
                },
                      new Post()
                {
                    Title = "LOREM",
                    Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    CategoryId=1,
                    Date= DateTime.Now.AddDays(-4),
                },
                        new Post()
                {
                    Title = "LOREM",
                    Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    CategoryId=3,
                    Date= DateTime.Now,
                }


                } ;
            foreach (var item in posts)
            {
                context.Posts.Add(item);

            }
            context.SaveChanges();

          

            base.Seed(context);
        }
    }
}