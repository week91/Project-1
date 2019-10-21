﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyNews.ViewsModel
{
    public class CreatUserVM
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
