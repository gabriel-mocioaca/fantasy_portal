using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class Book
  {
    public string BookId { get; set; }
    public string Name { get; set; }
    public int WordCount { get; set; }
    public string Image { get; set; }
    public string Synopsis { get; set; }
    public float Rating { get; set; }
    public ICollection<BookAuthor> BookAuthors { get; set; }
    public ICollection<BookPublisher> BookPublishers { get; set; }
    public ICollection<BookSubgenre> BookSubgenres { get; set; }
    public ICollection<UserBook> UserBooks { get; set; }
  }
}
