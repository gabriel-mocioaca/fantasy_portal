using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class HomeViewModel
  {
    public Book Book { get; set; }
    public Author Author { get; set; }
  }
}
