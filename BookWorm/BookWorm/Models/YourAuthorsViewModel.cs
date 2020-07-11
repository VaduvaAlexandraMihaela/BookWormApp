using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class YourAuthorsViewModel
    {
        public IEnumerable<Review> Reviews { get; set; }

        public IEnumerable<Author> Authors { get; set; }
    }
}
