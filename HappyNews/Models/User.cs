﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HappyNews.Models
{
    public class User:IdentityUser

    {
    public string FullName { get; set; }
    
    }
}
