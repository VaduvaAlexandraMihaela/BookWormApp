﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Data
{
    public class Author
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public string Name { get; set; }

    }
}
