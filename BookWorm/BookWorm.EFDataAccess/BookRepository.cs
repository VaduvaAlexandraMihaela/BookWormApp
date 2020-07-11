using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
   public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(BookWormDbContext dbContext): base(dbContext)
        {

        }
        public Book GetBookByBookId(Guid bookId)
        {
            var oneBook = dbContext.Books.Where(p => p.Id == bookId).SingleOrDefault();
            return oneBook;
        }

        public Book GetBookByName(string bookname)
        {
            var oneBook = dbContext.Books.Where(p => p.Name == bookname).SingleOrDefault();
            return oneBook;
        }

        public Book GetBookByUserId(Guid userId)
        {
            //var oneBook = dbContext.Books.Where(p => p.User.Any(user => user.Id == userId)).SingleOrDefault();
            //return oneBook;
            throw NotImplementedException();
        }

        private Exception NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
