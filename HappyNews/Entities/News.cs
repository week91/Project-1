using System;
using System.Collections.Generic;
using HappyNews.Entities;

namespace HappyNews.Models
{
    public class News: DbEntities
    {
        public Guid IdNews { get; set; }
        public string NewsTitle { get; set; }
        public string Source { get; set; }
        public DateTime DateCreate { get; set; }
        public string BodyNews { get; set; }
        public string IndexOfPosition { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}
