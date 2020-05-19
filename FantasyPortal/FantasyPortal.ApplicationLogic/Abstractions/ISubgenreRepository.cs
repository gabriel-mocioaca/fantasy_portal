using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface ISubgenreRepository : IRepository<Subgenre>
  {
    Subgenre GetSubgenreBySubgenreId(string subgenreId);
    IEnumerable<Book> GetBooksBySubgenreId(string subgenreId);
  }
}
