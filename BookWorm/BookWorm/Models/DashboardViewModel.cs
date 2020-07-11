using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<Review> Reviews { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

    }
}
