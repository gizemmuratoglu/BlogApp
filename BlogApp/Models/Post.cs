using System;

namespace BlogApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }


    }
}