using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
    public class BookPublisher
    {
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public Book Books { get; set; }
        public Publisher Publishers { get; set; }
    }
}
