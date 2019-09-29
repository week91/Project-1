﻿// <auto-generated />
using System;
using HappyNews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HappyNews.Migrations
{
    [DbContext(typeof(DbContent))]
    [Migration("20190929175754_555")]
    partial class _555
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HappyNews.Models.Admins", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IdAdmins");

                    b.Property<string>("Mail");

                    b.Property<string>("Name");

                    b.HasKey("id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HappyNews.Models.Comments", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText");

                    b.Property<DateTime>("DateOfCreate");

                    b.Property<Guid>("IdComments");

                    b.Property<Guid>("NewsId");

                    b.Property<Guid>("UseriD");

                    b.HasKey("id");

                    b.HasIndex("NewsId");

                    b.HasIndex("UseriD");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("HappyNews.Models.News", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyNews");

                    b.Property<DateTime>("DateCreate");

                    b.Property<Guid>("IdNews");

                    b.Property<string>("IndexOfPosition");

                    b.Property<string>("NewsTitle");

                    b.Property<string>("Source");

                    b.HasKey("id");

                    b.ToTable("Newses");
                });

            modelBuilder.Entity("HappyNews.Models.Users", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IdUsers");

                    b.Property<string>("Mail");

                    b.Property<string>("Name");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HappyNews.Models.Comments", b =>
                {
                    b.HasOne("HappyNews.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HappyNews.Models.Users", "User")
                        .WithMany("UserComments")
                        .HasForeignKey("UseriD")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
