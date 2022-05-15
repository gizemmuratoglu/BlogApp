using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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