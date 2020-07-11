using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Book> books { get; set; }

        public IEnumerable<Author> authors { get; set; }
    }
}
