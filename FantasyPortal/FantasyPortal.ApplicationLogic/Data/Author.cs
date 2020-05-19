using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class Author
  {
    public string AuthorId { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public int Popularity { get; set; }
    public ICollection<BookAuthor> BookAuthors { get; set; }
  }
}
