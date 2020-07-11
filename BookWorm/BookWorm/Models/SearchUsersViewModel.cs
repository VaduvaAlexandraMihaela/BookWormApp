using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Models
{
    public class SearchUsersViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}
