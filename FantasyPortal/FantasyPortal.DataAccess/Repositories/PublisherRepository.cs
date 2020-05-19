using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class PublisherRepository : Repository<Publisher>, IPublisherRepository
  {
    public PublisherRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }
    
    public Publisher GetPublisherByPublisherId(string publisherId)
    {
      var result = dbContext.Publishers.SingleOrDefault(publ => publ.PublisherId == publisherId);
      return result;
    }
    public IEnumerable<Book> GetBooksByPublisherId(string publisherId)
    {
      var result = dbContext.Books.Where(book => book.BookPublishers.Any(publisher => publisher.PublisherId == publisherId));
      return result;
    }
  }
}
