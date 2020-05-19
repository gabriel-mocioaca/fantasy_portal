using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class PublisherViewModel
  {
    public string PublisherId { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public IEnumerable<Book> Books { get; set; }
  }
}
