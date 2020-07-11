using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookWorm.DataAccess
{
   public class ReplyRepository : BaseRepository<Reply>, IReplyRepository
    {
        public ReplyRepository (BookWormDbContext dbContext) : base(dbContext)
        {

        }

        public Reply GetReplyById(Guid replyId)
        {
            throw new NotImplementedException();
        }

        public Reply GetReplyByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Reply GetReplyByComment(Comment comment)
        {
            var oneReply = dbContext.Replies.Where(p => p.Comment == comment).SingleOrDefault();
            return oneReply;
        }


    }
}
