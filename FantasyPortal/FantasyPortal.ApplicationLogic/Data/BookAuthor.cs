using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Book Books { get; set; }
        public Author Authors { get; set; }
    }
}
