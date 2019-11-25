using System;
using HappyNews.Entities;

namespace HappyNews.Models
{
    public class Comments : DbEntities

    {
        public DateTime DateOfCreate { get; set; }
        public string CommentText { get; set; }
        public Guid NewsId { get; set; }

        public string Userid { get; set; }
        public News News { get; set; }
       


    }
}
