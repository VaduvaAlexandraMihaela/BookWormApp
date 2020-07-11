using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class GetAllReviewsViewModel
    {
        public IEnumerable<Review> Reviews { get; set; }

    }
}
