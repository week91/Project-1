﻿using Microsoft.AspNetCore.Identity;

namespace Data.Models
{
    public class User : IdentityUser

    {
        public string FullName { get; set; }

    }
}
