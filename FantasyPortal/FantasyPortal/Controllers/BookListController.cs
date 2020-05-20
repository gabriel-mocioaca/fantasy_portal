using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using FantasyPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class BookListController : Controller
  {
    private IUserRepository userRepository; 
    private IUserBookRepository userBookRepository;
    private IBookRepository bookRepository;
    private readonly UserManager<IdentityUser> _userManager;
  
    public BookListController( IUserRepository userRepository, IUserBookRepository userBookRepository, IBookRepository bookRepository, UserManager<IdentityUser> userManager)
    {
      this.userBookRepository = userBookRepository;
      this.userRepository = userRepository;
      this.bookRepository = bookRepository;
      _userManager = userManager;
    }

    public IActionResult BookList()
    {
      string userId = _userManager.GetUserId(User).ToString();
      if (!userRepository.CheckIfUserExists(userId))
      {
        userRepository.AddUser(userId);
      }

      IEnumerable<UserBookViewModel> model = userBookRepository.GetUserBooksByUserId(userId).Select(s => new UserBookViewModel
      {
        UserId = s.UserId,
        Book = bookRepository.GetBookByBookId(s.BookId),
        Progress = s.Progress,
        Mark = s.Mark,
      });

      return View(model);
    }
    [HttpGet]
    public IActionResult BookListItemEdit(string userId, string bookId)
    {
      var userBook = userBookRepository.getUserBook(userId, bookId);
      BookListItemEditViewModel model = new BookListItemEditViewModel
      {
        UserId = userBook.UserId,
        BookId = userBook.BookId,
        Progress = userBook.Progress,
        Mark = userBook.Mark,
        Review = userBook.Review,
      };
      return View(model);
    }

    [HttpPost]
    public IActionResult BookListItemEdit(BookListItemEditViewModel model)
    {
      var x = new UserBook
      {
        UserId = model.UserId,
        BookId = model.BookId,
        Progress = model.Progress,
        Mark = model.Mark,
        Review = model.Review,
      };
      userBookRepository.Update(x);
      return RedirectToAction("BookList", "BookList");
    }

    [HttpPost]
    public ActionResult AddBook(string bookId)
    {
      if (!userRepository.CheckIfUserExists(_userManager.GetUserId(User).ToString()))
      {
        userRepository.AddUser(_userManager.GetUserId(User).ToString());
      }
      //string UserId = _userManager.GetUserId(User).ToString();
      //donateRepository.Add(new DonateModel()
      //{
      //  DonationId = viewModel.DonationId,
      //  FirstName = viewModel.FirstName,
      //  LastName = viewModel.LastName,
      //  CardNumber = viewModel.CardNumber,
      //  Amount = viewModel.Amount,
      //  UserId = UserId
      //});

      ViewBag.message = "Your donation was successful!";

      return View();
    }
  } 
}