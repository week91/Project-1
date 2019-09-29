using System;
using HappyNews.Entities;

namespace HappyNews.Models
{
    public class Admins:DbEntities
    {
        public Guid IdAdmins { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

    }
}
