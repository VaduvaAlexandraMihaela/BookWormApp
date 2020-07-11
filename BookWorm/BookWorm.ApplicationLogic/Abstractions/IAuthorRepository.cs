using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorByAuthorId(Guid authorId);
        object GetAuthorByUserId(Guid userIdGuid);

        Author GetAuthorByName(string authorName);
    }
}
