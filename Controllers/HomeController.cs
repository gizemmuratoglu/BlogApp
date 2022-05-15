using BlogApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home

        public PartialViewResult ItemList()
        {
            List<CoronaData> corList = null;
            WebClient client = new WebClient();
            var json = client.DownloadString("https://api.covidtracking.com/v1/us/daily.json");
            corList = JsonConvert.DeserializeObject<List<CoronaData>>(json);
            if(corList== null)
            {
                return null;
            }
            return PartialView(corList.ToList());
        }

        
        public ActionResult Index()
        {
            

            var posts = context.Posts.Select(i =>
                new PostModel()
                {
                    Id = i.Id,
                    Title = i.Title,
                    Text = i.Text,
                    Date = i.Date,
                    CategoryName = i.Category.CategoryName,
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