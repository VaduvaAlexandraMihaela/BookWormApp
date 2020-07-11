using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class YourBooksViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
    }
}
