using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
  public class User
  { 
    public string UserId { get; set; }
    public ICollection<UserBook> UserBooks { get; set; }
  }
}
