using HappyNews.Models;

namespace HappyNews.Repo
{
    public class AdminsRepo:EntityFrameworkRepo<Admins>
    {
        public AdminsRepo(DbContent _context) : base (_context)
        {

        }
    }
}
