using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class BookSubgenre
  {
    public string BookId { get; set; }
    public string SubgenreId { get; set; }
    public Book Book { get; set; }
    public Subgenre Subgenre { get; set; }
  }
}
