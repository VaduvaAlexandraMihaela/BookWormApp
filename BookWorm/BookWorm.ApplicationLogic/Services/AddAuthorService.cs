using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.ApplicationLogic.Services
{
   public class AddAuthorService
    {
        private IAuthorRepository authorRepository;
       // private IUserRepository userRepository;

        public AddAuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public Author GetAuthorByAuthorId(string authorId)
        {
            Guid authorIdGuid = Guid.Empty;

            if (!Guid.TryParse(authorId, out authorIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var book = authorRepository.GetAuthorByAuthorId(authorIdGuid);

            if (book == null)
            {
                throw new EntityNotFoundException(authorIdGuid);
            }

            return book;
        }

       

        public IEnumerable<Author> GetUserAuthors(string userId)
        {
            Guid userIdGuid = Guid.Empty;

            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return authorRepository.GetAll()
                .Where(Book => Book.User != null && Book.User.Id == userIdGuid)
                .AsEnumerable();
        }

        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public void AddAuthor(string authorName, User user)
        {
            authorRepository.Add(new Author() { Id = Guid.NewGuid(), User = user, Name = authorName });
        }

        public void DeleteAuthor(Guid bookId)
        {
            var book = authorRepository.GetAuthorByAuthorId(bookId);
            authorRepository.Delete(book);
        }
    }
}
