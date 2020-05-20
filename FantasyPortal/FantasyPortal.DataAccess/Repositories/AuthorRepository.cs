using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class AuthorRepository : Repository<Author>, IAuthorRepository
  {
    public AuthorRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }

    public Author GetRandomAuthor()
    {
      int total = dbContext.Authors.Count();
      Random r = new Random();
      int offset = r.Next(0, total);

      var result = dbContext.Authors.Skip(offset).FirstOrDefault();

      return result;
    }

    public Author GetAuthorByAuthorId(string authorId)
    {
      var result = dbContext.Authors.SingleOrDefault(author => author.AuthorId == authorId);
      return result;
    }

    public IEnumerable<Book> GetBooksByAuthorId(string authorId)
    {
      var result = dbContext.Books.Where(book => book.BookAuthors.Any(author => author.AuthorId == authorId));
      return result;
    }
  }
}
