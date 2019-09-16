using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public DateTime DateCreate { get; set; }
        public string NewText { get; set; }
        public string IndexOfPosition { get; set; }
        public ICollection<Comments> Comments { get; set; }

        public News()
        {
            Comments = new List<Comments>();
        }

    }
}
