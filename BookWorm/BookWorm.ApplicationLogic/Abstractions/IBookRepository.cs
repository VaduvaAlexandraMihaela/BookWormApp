using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IBookRepository:IRepository<Book>
    {
        Book GetBookByBookId(Guid bookId);

        Book GetBookByUserId(Guid userId);

        Book GetBookByName(string bookname);
    }
}
