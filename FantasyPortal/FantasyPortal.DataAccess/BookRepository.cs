using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.DataAccess
{
  public class BookRepository : Repository<Book>, IBookRepository
  {
    public BookRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {

    }
  }
}
