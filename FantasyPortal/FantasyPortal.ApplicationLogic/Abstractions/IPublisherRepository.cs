﻿using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface IPublisherRepository : IRepository<Publisher>
  {
    Publisher GetPublisherByPublisherId(string publisherId);
    IEnumerable<Book> GetBooksByPublisherId(string publisherId);
  }
}
