using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
   public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BookWormDbContext dbContext) : base(dbContext)
        {

        }

        public Comment GetCommentById(Guid commentId)
        {
            var oneComment = dbContext.Comments.Where(p => p.Id == commentId).SingleOrDefault();
            return oneComment;
        }

        public Comment GetCommentByReview(Review review)
        {
            var oneComment = dbContext.Comments.Where(p => p.Review == review).SingleOrDefault();
            return oneComment;
        }

        public Comment GetCommentByUserId(Guid userId)
        {
            throw NotImplementedException();
        }

        private Exception NotImplementedException()
        {
            throw new NotImplementedException();
        }


    }
}
