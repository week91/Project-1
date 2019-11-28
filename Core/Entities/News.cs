using System;
using System.Collections.Generic;

namespace HappyNews.Entities
{
    public class News: DbEntities
    {
        public string NewsTitle { get; set; }
        public string Source { get; set; }
        public DateTime DateCreate { get; set; }
        public string BodyNews { get; set; }
        public string IndexOfPosition { get; set; }
        public string StartPict { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}
