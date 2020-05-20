using FantasyPortal.ApplicationLogic.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class UserBookViewModel
  {
    public string UserId { get; set; }
    public Book Book { get; set; }
    public string Progress { get; set; }
    public int Mark { get; set; }
    public string Review { get; set; }
  }
}
