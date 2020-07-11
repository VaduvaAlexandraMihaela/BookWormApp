using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Data
{
    public class User_Follower
    {
        public Guid Id { get; set; }

        public User User { get; set; }
    }
}
