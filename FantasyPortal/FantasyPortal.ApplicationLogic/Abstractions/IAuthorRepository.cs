using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface IAuthorRepository : IRepository<Author>
  {
    Author GetRandomAuthor();
    Author GetAuthorByAuthorId(string authorId);
    IEnumerable<Book> GetBooksByAuthorId(string authorId);
  }
}
