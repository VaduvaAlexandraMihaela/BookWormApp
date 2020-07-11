using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IReviewRepository:IRepository<Review>
    {
        Review GetReviewbyReviewId(Guid reviewId);
        Review GetReviewbyUserId(Guid userId);
        Review GetReviewByReviewName(string reviewTitle);
    }
}
