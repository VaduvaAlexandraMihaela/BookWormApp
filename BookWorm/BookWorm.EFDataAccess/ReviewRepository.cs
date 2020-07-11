using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
   public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(BookWormDbContext dbContext) : base(dbContext)
        {

        }

        public Review GetReviewbyReviewId(Guid reviewId)
        {
            var oneReview = dbContext.Reviews.Where(p => p.Id == reviewId).SingleOrDefault();
            return oneReview;
        }

        public Review GetReviewbyUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewByReviewName(string reviewTitle)
        {
            var oneReview = dbContext.Reviews.Where(p => p.Title == reviewTitle).SingleOrDefault();
            return oneReview;
        }
    }
}
