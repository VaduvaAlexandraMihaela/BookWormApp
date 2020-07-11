using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookWorm.ApplicationLogic;
using BookWorm.ApplicationLogic.Data;

namespace BookWorm.DataAccess
{
   public class BookWormDbContext: DbContext
    {
        public BookWormDbContext(DbContextOptions<BookWormDbContext> options) : base(options)

        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User_Follower> Followers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}
