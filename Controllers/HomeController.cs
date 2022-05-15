using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var posts = context.Posts.Select(i=>
                new PostModel()
                {
                    Id=i.Id,
                    Title=i.Title,
                    Text=i.Text,
                    Date=i.Date,
                    CategoryName=i.Category.CategoryName,
                });
            return View(posts.ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult BlogPost()
        {
            return View();
        }




    }
}