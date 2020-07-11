using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.ApplicationLogic.Services
{
    public class AddBookService
    {
        private IBookRepository bookRepository;
        // private IUserRepository userRepository;
        public int nrBook;

        public AddBookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book GetBookByBookId(string bookId)
        {
            Guid bookIdGuid = Guid.Empty; 

            if(!Guid.TryParse(bookId, out bookIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var book = bookRepository.GetBookByBookId(bookIdGuid);

            if(book == null)
            {
                throw new EntityNotFoundException(bookIdGuid); 
            }

            return book;
        }

        public Book GetBookbyUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;

            if(!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var book = bookRepository.GetBookByUserId(userIdGuid); 
            if( book == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return book;

        }

        public IEnumerable<Book> GetAll()
        {
            return bookRepository.GetAll();
        }

        public IEnumerable<Book> GetUserBooks(string userId)
        {
            Guid userIdGuid = Guid.Empty; 

            if(!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return bookRepository.GetAll()
                .Where(Book => Book.User != null && Book.User.Id == userIdGuid)
                .AsEnumerable();
        }

        public void AddBook(string bookName, User user)
        {

            bookRepository.Add(new Book() { Id = Guid.NewGuid(), User = user, Name=bookName });
            
        }

        public void DeleteBook(Guid bookId)
        {
            var book = bookRepository.GetBookByBookId(bookId);
            bookRepository.Delete(book);
        }
    }
}
