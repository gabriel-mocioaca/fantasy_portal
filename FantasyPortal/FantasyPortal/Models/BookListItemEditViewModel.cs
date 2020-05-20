using FantasyPortal.ApplicationLogic.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class BookListItemEditViewModel
  {
    public string UserId { get; set; }
    public string BookId { get; set; }
    public string Progress { get; set; }
    public int Mark { get; set; }
    public string Review { get; set; }
    public List<SelectListItem> ProgressList { get; set; } = new List<SelectListItem>
      {
        new SelectListItem { Value = "Reading", Text = "Reading" },
        new SelectListItem { Value = "Completed", Text = "Completed" },
        new SelectListItem { Value = "To Read", Text = "To Read"  },
      };
    public List<SelectListItem> MarkList { get; set; } = new List<SelectListItem>
      {
        new SelectListItem { Value = "0", Text = "0" },
        new SelectListItem { Value = "1", Text = "1" },
        new SelectListItem { Value = "2", Text = "2"  },
        new SelectListItem { Value = "3", Text = "3" },
        new SelectListItem { Value = "4", Text = "4" },
        new SelectListItem { Value = "5", Text = "5"  },
      };
  }
}
