using Model1;

namespace CoreApp
{
    public class CommentsRepo : EntityFrameworkRepo<Comments>
    {
        public CommentsRepo(DbContent _context) : base(_context)
        {

        }
    }
}
