﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPortal.Models
{
  public class BookViewModel
  {
    public int BookId { get; set; }
    public string Name { get; set; }
    public int WordCount { get; set; }
    public string Image { get; set; }
    public string Synopsis { get; set; }
    public float Rating { get; set; }
  }
}
