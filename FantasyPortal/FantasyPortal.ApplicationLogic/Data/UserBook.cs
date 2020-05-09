using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Data
{
    public class UserBook
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public User Users { get; set; }
        public Book Books { get; set; }
        public string Progress { get; set; }
        public int Mark { get; set; }
        public string Review { get; set; }
    }
}
