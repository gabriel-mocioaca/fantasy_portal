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

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookPublisher> BookPublishers { get; set; }
    public DbSet<BookSubgenre> BookSubgenres { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Subgenre> Subgenres { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserBook> UserBooks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Book>().HasKey(t => t.BookId);
      modelBuilder.Entity<Author>().HasKey(t => t.AuthorId);
      modelBuilder.Entity<Subgenre>().HasKey(t => t.SubgenreId);
      modelBuilder.Entity<Publisher>().HasKey(t => t.PublisherId);
      modelBuilder.Entity<User>().HasKey(t => t.UserId);

      modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });
      modelBuilder.Entity<BookAuthor>().HasOne(bc => bc.Book).WithMany(au => au.BookAuthors).HasForeignKey(bc => bc.BookId);
      modelBuilder.Entity<BookAuthor>().HasOne(bc => bc.Author).WithMany(bu => bu.BookAuthors).HasForeignKey(bc => bc.AuthorId);

      modelBuilder.Entity<BookPublisher>().HasKey(x => new { x.BookId, x.PublisherId });
      modelBuilder.Entity<BookPublisher>().HasOne(bp => bp.Book).WithMany(pu => pu.BookPublishers).HasForeignKey(bp => bp.BookId);
      modelBuilder.Entity<BookPublisher>().HasOne(bp => bp.Publisher).WithMany(bu => bu.BookPublishers).HasForeignKey(bp => bp.PublisherId);

      modelBuilder.Entity<BookSubgenre>().HasKey(x => new { x.BookId, x.SubgenreId });
      modelBuilder.Entity<BookSubgenre>().HasOne(bs => bs.Book).WithMany(su => su.BookSubgenres).HasForeignKey(bs => bs.BookId);
      modelBuilder.Entity<BookSubgenre>().HasOne(bs => bs.Subgenre).WithMany(bu => bu.BookSubgenres).HasForeignKey(bs => bs.SubgenreId);

      modelBuilder.Entity<UserBook>().HasKey(x => new { x.UserId, x.BookId });
      modelBuilder.Entity<UserBook>().HasOne(ub => ub.User).WithMany(us => us.UserBooks).HasForeignKey(ub => ub.UserId);
      modelBuilder.Entity<UserBook>().HasOne(ub => ub.Book).WithMany(bu => bu.UserBooks).HasForeignKey(ub => ub.BookId);

      base.OnModelCreating(modelBuilder);
    }
  }
}

