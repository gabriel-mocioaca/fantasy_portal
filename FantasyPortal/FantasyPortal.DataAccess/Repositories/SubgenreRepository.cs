using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class SubgenreRepository : Repository<Subgenre>, ISubgenreRepository
  {
    public SubgenreRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }

    public Subgenre GetSubgenreBySubgenreId(string subgenreId)
    {
      var result = dbContext.Subgenres.SingleOrDefault(subgenre => subgenre.SubgenreId == subgenreId);
      return result;
    }

    public IEnumerable<Book> GetBooksBySubgenreId(string subgenreId)
    {
      var result = dbContext.Books.Where(book => book.BookSubgenres.Any(subgenre => subgenre.SubgenreId == subgenreId));
      return result;
    }
  }
}
