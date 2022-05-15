using System;
using System.Collections.Generic;

namespace BlogApp.Models
{
    public class Category

    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public List<Post> Posts { get; set; }
    }
}