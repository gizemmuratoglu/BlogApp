﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogApp.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string roleName, string description)
        {
            this.Description = description;
        }

    }
}