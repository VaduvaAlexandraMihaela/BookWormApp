using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
    public class AuthorRepository: BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookWormDbContext dbContext) : base (dbContext)
        {

        }

        public Author GetAuthorByAuthorId(Guid authorId)
        {
            var oneAuthor = dbContext.Authors.Where(p => p.Id == authorId).SingleOrDefault();
            return oneAuthor;
        }

        public Author GetAuthorByName(string authorName)
        {
            var oneAuthor = dbContext.Authors.Where(p => p.Name == authorName).SingleOrDefault();
            return oneAuthor;
        }

        public object GetAuthorByUserId(Guid userIdGuid)
        {
            // var oneAuthor = dbContext.Authors.Where(p => p.User.Any(user => user.Id == userIdGuid)).SingleOrDefault();
           // return oneAuthor;

            return NotImplementedException();
        }

        private object NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
