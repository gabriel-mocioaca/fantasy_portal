using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FantasyPortal.Models;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;

namespace FantasyPortal.Controllers
{
  public class HomeController : Controller
  {
    private IBookRepository bookRepository;
    private IAuthorRepository authorRepository;

    public HomeController(IBookRepository bookRepository, IAuthorRepository authorRepository)
    {
      this.bookRepository = bookRepository;
      this.authorRepository = authorRepository;
    }

    public IActionResult Index()
    {
      HomeViewModel model = new HomeViewModel
      {
        Book = bookRepository.GetRandomBook(),
        Author = authorRepository.GetRandomAuthor(),
      };
      return View(model);
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Privacy()
    {
       return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
