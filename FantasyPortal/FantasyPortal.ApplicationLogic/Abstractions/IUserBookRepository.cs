using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface IUserBookRepository : IRepository<UserBook>
  {
    UserBook getUserBook(string userId, string bookId);
    IEnumerable<UserBook> GetUserBooksByUserId(string userId);
  }
}
