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
      throw new NotImplementedException();
    }
  }
}
