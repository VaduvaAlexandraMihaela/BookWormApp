using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Data
{
    public class Reply
    {
        public Guid Id { get; set; }

        public Comment Comment { get; set; }

        public User User { get; set; }

        public string Text { get; set; }
    }
}
