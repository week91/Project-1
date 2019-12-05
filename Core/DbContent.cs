using Core.Models;
using HappyNews.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public sealed class DbContent : IdentityDbContext<User>

    {
        public DbSet<News> Newses { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<User> User1 { get; set; }
       
       public DbContent(DbContextOptions<DbContent> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}