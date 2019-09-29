﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HappyNews
{
    public sealed class DbContent : DbContext

    {
        public DbSet<News> Newses { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Admins> Admin { get; set; }

        public DbContent(DbContextOptions<DbContent> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
