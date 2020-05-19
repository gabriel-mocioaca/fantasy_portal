using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class BookAuthor
  {
    public string BookId { get; set; }
    public string AuthorId { get; set; }
    public Book Book { get; set; }
    public Author Author { get; set; }
  }
}
