using HappyNews.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repo
{
    public class CommentsRepo:EntityFrameworkRepo<Comments>
    {
        public CommentsRepo(DbContent _context) : base(_context)
        {

        }
    }
}
