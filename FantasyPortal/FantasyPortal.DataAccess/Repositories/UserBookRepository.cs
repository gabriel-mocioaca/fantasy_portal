using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class UserBookRepository : Repository<UserBook>, IUserBookRepository
  {
    public UserBookRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<UserBook> GetUserBooksByUserId(string userId)
    {
      var result = dbContext.UserBooks.Where(userbook => userbook.UserId == userId);
      return result;
    }

    public UserBook getUserBook(string userId, string bookId)
    {
      var result = dbContext.UserBooks.SingleOrDefault(userbook => (userbook.UserId == userId && userbook.BookId == bookId));
      return result;
    }
  }
}
