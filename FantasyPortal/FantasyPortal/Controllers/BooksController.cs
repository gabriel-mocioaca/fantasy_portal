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

    public IActionResult Books()
    {
      IEnumerable<BookViewModel> model = bookRepository.GetAll().Select(s => new BookViewModel
      {
        BookId = s.BookId,
        Name = $"{s.Name}",
        Authors = bookRepository.GetAuthorsByBookId(s.BookId),
        Image = s.Image,
        Synopsis = s.Synopsis,
        Rating = s.Rating,
      });
      return View(model);
    }

    [HttpGet]
    public IActionResult Book(string id)
    {
      var book = bookRepository.GetBookByBookId(id);
      BookViewModel model = new BookViewModel
      {
        BookId = book.BookId,
        Name = $"{book.Name}",
        Authors = bookRepository.GetAuthorsByBookId(book.BookId),
        Image = book.Image,
        Synopsis = book.Synopsis,
        Rating = book.Rating,
      };

      return View(model);
    }
  }
}