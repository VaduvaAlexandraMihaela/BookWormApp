using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IUser_FollowerRepository: IRepository<User_Follower>
    {
        User_Follower GetFollowerById(Guid Id);
        User_Follower GetFollowerByUserFirstName(string name);
    }
}
