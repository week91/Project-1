using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model1;

namespace CoreApp
{
    public sealed class DbContent : IdentityDbContext

    {
        public DbSet<News> Newses { get; set; }
        public DbSet<Comments> Comment { get; set; }
      //  public DbSet<IdentityUser> User { get; set; }
       
       public DbContent(DbContextOptions<DbContent> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}