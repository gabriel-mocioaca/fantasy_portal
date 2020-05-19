using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class Publisher
  {
    public string PublisherId { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public ICollection<BookPublisher> BookPublishers { get; set; }
  }
}
