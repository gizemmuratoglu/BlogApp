using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Login
    {
        [Required]
        [DisplayName("UserName")]
        public String UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        public String Password { get; set; }

       
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }


    }
}