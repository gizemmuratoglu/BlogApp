using System;

namespace BlogApp.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public String CategoryName { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
    }
}