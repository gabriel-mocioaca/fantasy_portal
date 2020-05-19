using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class Subgenre
  {
    public string SubgenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<BookSubgenre> BookSubgenres { get; set; }
  }
}
