using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Data
{
   public class Comment
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Review Review { get; set; }

        public string Text { get; set; }
    }
}
