using HappyNews.Models;

namespace HappyNews.Repo
{
    public class CommentsRepo:EntityFrameworkRepo<Comments>
    {
        public CommentsRepo(DbContent _context) : base(_context)
        {

        }
    }
}
