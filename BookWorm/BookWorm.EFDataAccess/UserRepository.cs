using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BookWormDbContext dbContext) : base (dbContext)
        {

        }

        public User GetUserByUserEmail(string userEmail)
        {
            var oneUser = dbContext.Users.Where(p => p.Email == userEmail).SingleOrDefault();
            return oneUser;
        }

        public User GetUserByUserId(Guid userID)
        {
            var oneUser = dbContext.Users.Where(p => p.Id == userID).SingleOrDefault();
            return oneUser;
        }

       
    }
}
