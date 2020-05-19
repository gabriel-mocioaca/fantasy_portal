using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class Book
  {
    public int BookId { get; set; }
    public string Name { get; set; }
    public int WordCount { get; set; }
    public string Image { get; set; }
    public string Synopsis { get; set; }
    public float Rating { get; set; }
  }
}
