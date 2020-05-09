using FantasyPortal.ApplicationLogic.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.DataAccess
{
    public class FantasyPortalDbContext : DbContext
    {
        public FantasyPortalDbContext(DbContextOptions<FantasyPortalDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(t => t.BookId);
            modelBuilder.Entity<Author>().HasKey(t => t.AuthorId);
            modelBuilder.Entity<Subgenre>().HasKey(t => t.SubgenreId);
            modelBuilder.Entity<Publisher>().HasKey(t => t.PublisherId);
            modelBuilder.Entity<User>().HasKey(t => t.UserId);

            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });
            modelBuilder.Entity<BookPublisher>().HasKey(x => new { x.BookId, x.PublisherId });
            modelBuilder.Entity<BookSubgenre>().HasKey(x => new { x.BookId, x.SubgenreId });
            modelBuilder.Entity<UserBook>().HasKey(x => new { x.UserId, x.BookId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

