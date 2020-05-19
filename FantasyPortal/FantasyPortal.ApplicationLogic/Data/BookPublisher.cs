using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class BookPublisher
  {
    public string BookId { get; set; }
    public string PublisherId { get; set; }
    public Book Book { get; set; }
    public Publisher Publisher { get; set; }
  }
}
