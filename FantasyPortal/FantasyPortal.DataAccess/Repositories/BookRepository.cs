using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class BookRepository : Repository<Book>, IBookRepository
  {
    public BookRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }
    public Book GetRandomBook()
    {
      throw new NotImplementedException();
    }
    public Book GetBookByBookId(string bookId)
    {
      var result = dbContext.Books.SingleOrDefault(book => book.BookId == bookId);
      return result;
    }

    public IEnumerable<Author> GetAuthorsByBookId(string bookId)
    {
      var result = dbContext.Authors.Where(auth => auth.BookAuthors.Any(book => book.BookId == bookId));
      return result;
    }

    public IEnumerable<Publisher> GetPublishersByBookId(string bookId)
    {
      var result = dbContext.Publishers.Where(auth => auth.BookPublishers.Any(book => book.BookId == bookId));
      return result;
    }

    public IEnumerable<Subgenre> GetSubgenresByBookId(string bookId)
    {
      var result = dbContext.Subgenres.Where(auth => auth.BookSubgenres.Any(book => book.BookId == bookId));
      return result;
    }

    
  }
}
