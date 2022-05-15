using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Register
    {
        public String Name { get; set; }
        [Required]
        public String UserName { get; set; }

        [Required]
        public String Password { get; set; }

    }
}