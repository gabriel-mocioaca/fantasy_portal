using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface IBookRepository : IRepository<Book>
  {
    IEnumerable<Author> GetAuthorsByBookId(string bookId);
    IEnumerable<Publisher> GetPublishersByBookId(string bookId);
    IEnumerable<Subgenre> GetSubgenresByBookId(string bookId);
  }
}
