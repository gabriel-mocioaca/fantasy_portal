using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class BooksController : Controller
  {
    private IBookRepository bookRepository;

    public BooksController(IBookRepository bookRepository)
    {
      this.bookRepository = bookRepository;
    }

    public IActionResult Index()
    {
      IEnumerable<BookViewModel> model = bookRepository.GetAll().Select(s => new BookViewModel
      {
        BookId = s.BookId,
        Name = $"{s.Name}",
        Authors = bookRepository.GetBookAuthorsByBookId(s.BookId),
        Image = s.Image,
        Synopsis = s.Synopsis,
        Rating = s.Rating,
      }); ;
      return View(model);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
      ViewData["Message"] = "Book" + id.ToString();

      return View();
    }
  }
}