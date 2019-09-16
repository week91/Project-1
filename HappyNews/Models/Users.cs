using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyNews.Models
{
    public class Users
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public  ICollection<Comments> UserComments { get; set; }
        public Users()
        {
            UserComments =new List<Comments>();
        }
    }
}
