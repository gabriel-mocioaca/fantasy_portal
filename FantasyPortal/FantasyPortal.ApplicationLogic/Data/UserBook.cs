using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class UserBook
  {
    public string UserId { get; set; }
    public string BookId { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }
    public string Progress { get; set; }
    public int Mark { get; set; }
    public string Review { get; set; }
  }
}
