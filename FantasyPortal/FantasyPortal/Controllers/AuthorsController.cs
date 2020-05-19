using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class AuthorsController : Controller
  {
    private IAuthorRepository authorRepository;

    public AuthorsController(IAuthorRepository authorRepository)
    {
      this.authorRepository = authorRepository;
    }

    public IActionResult Authors()
    {
      IEnumerable<AuthorViewModel> model = authorRepository.GetAll().Select(s => new AuthorViewModel
      {
        AuthorId = s.AuthorId,
        Name = $"{s.Name}",
        Popularity = s.Popularity,
      });
      return View(model);
    }

    public IActionResult Author(string id)
    {
      var author = authorRepository.GetAuthorByAuthorId(id);
      AuthorViewModel model = new AuthorViewModel
      {
        AuthorId = author.AuthorId,
        Name = $"{author.Name}",
        Image = author.Image,
        Description = author.Description,
        Popularity = author.Popularity,
        Books = authorRepository.GetBooksByAuthorId(author.AuthorId),
      };

      return View(model);
    }
  }
}