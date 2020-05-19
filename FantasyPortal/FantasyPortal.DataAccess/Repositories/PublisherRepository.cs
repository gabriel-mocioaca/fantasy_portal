using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class PublisherRepository : Repository<Publisher>, IPublisherRepository
  {
    public PublisherRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }
  }
}
