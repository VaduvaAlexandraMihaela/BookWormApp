using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class AddReviewViewModel
    {
        public string Title { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string text { get; set; }
    }
}
