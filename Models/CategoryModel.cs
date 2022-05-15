using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public int PostsNum { get; set; }
    }
}