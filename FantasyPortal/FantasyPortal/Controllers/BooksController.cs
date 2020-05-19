using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class BooksController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Details(int id)
    {
      ViewData["Message"] = "Book" + id.ToString();

      return View();
    }
  }
}