using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Data
{
    public class Review
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Book Book { get; set; }

        public Author Author { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }
    }
}
