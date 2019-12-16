using Model1;

namespace CoreApp
{
    public class NewsRepositoryAPI : NewsRepositoryMem<News>
    {
        public NewsRepositoryAPI(DbContent _context) : base(_context)
        {
        }

    }
}
