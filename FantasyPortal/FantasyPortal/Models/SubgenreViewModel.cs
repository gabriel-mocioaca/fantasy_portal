using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class SubgenreViewModel
  {
    public string SubgenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<Book> Books { get; set; }
  }
}
