using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess
{
  public class BookRepository : Repository<Book>, IBookRepository
  {
    public BookRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {

    }

    public IEnumerable<Author> GetAuthorsByBookId(string bookId)
    {
      var result = dbContext.Authors.Where(auth => auth.BookAuthors.Any(book => book.BookId == bookId));
      return result;
    }

  }
}
