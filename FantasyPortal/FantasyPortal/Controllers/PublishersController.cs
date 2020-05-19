using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPortal.Controllers
{
  public class PublishersController : Controller
  {
    private IPublisherRepository publisherRepository;

    public PublishersController(IPublisherRepository publisherRepository)
    {
      this.publisherRepository = publisherRepository;
    }

    public IActionResult Publishers()
    {
      IEnumerable<PublisherViewModel> model = publisherRepository.GetAll().Select(s => new PublisherViewModel
      {
        PublisherId = s.PublisherId,
        Name = $"{s.Name}",
        Region = s.Region,
        Books = publisherRepository.GetBooksByPublisherId(s.PublisherId),
      }); ;
      return View(model);
    }

    public IActionResult Publisher(string id)
    {
      var publisher = publisherRepository.GetPublisherByPublisherId(id);
      PublisherViewModel model = new PublisherViewModel
      {
        PublisherId = publisher.PublisherId,
        Name = $"{publisher.Name}",
        Region = publisher.Region,
        Books = publisherRepository.GetBooksByPublisherId(publisher.PublisherId),
      };

      return View(model);
    }
  }
}