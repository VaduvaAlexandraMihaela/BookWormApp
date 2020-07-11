using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
   public class User_FollowerRepository : BaseRepository<User_Follower>, IUser_FollowerRepository
    {
        public User_FollowerRepository(BookWormDbContext dbContext) : base(dbContext)
        {

        }

        public User_Follower GetFollowerById(Guid Id)
        {
            var oneFollower = dbContext.Followers.Where(p => p.Id == Id).SingleOrDefault();
            return oneFollower;
        }

        public User_Follower GetFollowerByUserFirstName(string name)
        {
            var oneFollower = dbContext.Followers.Where(p => p.User.FirstName == name).SingleOrDefault();
            return oneFollower;
        }
    }
}
