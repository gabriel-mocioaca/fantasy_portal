using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class SubgenresController : Controller
  {
    private ISubgenreRepository subgenreRepository;
    public SubgenresController(ISubgenreRepository subgenreRepository)
    {
      this.subgenreRepository = subgenreRepository;
    }

    public IActionResult Subgenre(string id)
    {
      var subgenre = subgenreRepository.GetSubgenreBySubgenreId(id);
      SubgenreViewModel model = new SubgenreViewModel
      {
        SubgenreId = subgenre.SubgenreId,
        Name = $"{subgenre.Name}",
        Description = subgenre.Description,
        Books = subgenreRepository.GetBooksBySubgenreId(id),
      };

      return View(model);
    }
  }
}