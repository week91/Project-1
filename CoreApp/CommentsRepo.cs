using Model1;

namespace CoreApp
{
    public class CommentsRepo : NewsRepositoryMem<Comments>
    {
        public CommentsRepo(DbContent _context) : base(_context)
        {

        }
    }
}
