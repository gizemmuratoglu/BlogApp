using System;

namespace BlogApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public int PostsNum { get; set; }
    }
}