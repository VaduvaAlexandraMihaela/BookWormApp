using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUserByUserId(Guid userID);
        User GetUserByUserEmail(string userEmail);
    }
}
