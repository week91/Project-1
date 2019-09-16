using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyNews.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public DateTime DateOfCreate { get; set; }
        public string CommentText { get; set; }
        public int? UseriD { get; set; }
        public Users User { get; set; }
        public int? NewsId { get; set; }
        public News News { get; set; }

    }
}
