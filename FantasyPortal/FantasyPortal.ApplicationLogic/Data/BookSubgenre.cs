using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
    public class BookSubgenre
    {
        public int BookId { get; set; }
        public int SubgenreId { get; set; }
        public Book Books { get; set; }
        public Subgenre Subgenres { get; set; }
    }
}
