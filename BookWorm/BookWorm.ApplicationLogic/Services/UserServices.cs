using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Text;


namespace BookWorm.ApplicationLogic.Services
{
    public class UserServices
    {
        private IUserRepository userRepository;
        private IUser_FollowerRepository followerRepository;
        private IBookRepository bookRepository;
        private IAuthorRepository authorRepository;

        public UserServices(IUserRepository userRepository, IUser_FollowerRepository followerRepository, 
            IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this.userRepository = userRepository;
            this.followerRepository = followerRepository;
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }

        public void AddUser(string FirstName, string LastName, string Email, string Password)
        {
            userRepository.Add(new Data.User()
            {
                Id = Guid.NewGuid(),
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password
            });
        }

        public void AddFollower(User user)
        {
            followerRepository.Add(new User_Follower()
            {
                Id = Guid.NewGuid(), 
                User = user
            });
        }

        public User_Follower GetFollowerByFirstName(string name)
        {
            return followerRepository.GetFollowerByUserFirstName(name);
        }

        public User_Follower GetFollowerById(Guid id)
        {
            return followerRepository.GetFollowerById(id);
        }

        public ICollection<Book> GetFollowersBooks(User user)
        {
            var followers = followerRepository.GetAll();
            ICollection<User_Follower> user_Followers = new Collection<User_Follower>();
            ICollection<Book> followersBooks = new Collection<Book>();
            IEnumerable<Book> allBooks;
            allBooks = bookRepository.GetAll();

            foreach (var item in followers)
            {
                if (item.User == user)
                {
                    user_Followers.Add(item);
                }
            }

            foreach(var item1 in user_Followers)
            {
                foreach(var item2 in allBooks)
                {
                    if (item2.User == item1.User)
                    {
                        followersBooks.Add(item2);
                    }
                }
                
            }

            return followersBooks;
        }

        public ICollection<Author> GetFollowersAuthors(User user)
        {
            var followers = followerRepository.GetAll();
            ICollection<User_Follower> user_Followers = new Collection<User_Follower>();
            ICollection<Author> followersAuthors = new Collection<Author>();
            IEnumerable<Author> allAuthors;
            allAuthors = authorRepository.GetAll();

            foreach (var item in followers)
            {
                if (item.User == user)
                {
                    user_Followers.Add(item);
                }
            }

            foreach (var item1 in user_Followers)
            {
                foreach (var item2 in allAuthors)
                {
                    if (item2.User == item1.User)
                    {
                        followersAuthors.Add(item2);
                    }
                }

            }

            return followersAuthors;
        }

        public ICollection<User_Follower> GetUser_Followers(User user)
        {
            var followers = followerRepository.GetAll();
            ICollection < User_Follower > user_Followers= new Collection<User_Follower>(); 

            foreach(var item in followers)
            {
                if(item.User == user)
                {
                    user_Followers.Add(item);
                }
            }

            return user_Followers;
        }

        public User GetUserByUserEmail(string userEmail)
        {
            return userRepository.GetUserByUserEmail(userEmail);
        }

        public User GetUserById(Guid id)
        {
            return userRepository.GetUserByUserId(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public ICollection<User> GetUsersByName(string name)
        {
            ICollection<User> usersN = new Collection<User>();
            IEnumerable<User> users;
            users = userRepository.GetAll();
            foreach(var item in users)
            {
                if(item.FirstName == name || item.LastName == name)
                {
                    usersN.Add(item);
                }
            }

            return usersN;
        }
    }
}
