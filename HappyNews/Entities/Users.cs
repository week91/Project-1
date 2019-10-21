using System;
using System.Collections.Generic;
using System.Security.Principal;
using HappyNews.Entities;
using Microsoft.AspNetCore.Identity;

namespace HappyNews.Models
{
    public class Users : DbEntities
    {
        public Guid IdUsers { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public  ICollection<Comments> UserComments { get; set; }
      
    }
}
