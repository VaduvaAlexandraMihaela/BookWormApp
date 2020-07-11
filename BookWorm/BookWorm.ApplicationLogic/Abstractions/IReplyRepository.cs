using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Abstractions
{
    public interface IReplyRepository:IRepository<Reply>
    {
        Reply GetReplyById(Guid replyId);

        Reply GetReplyByUserId(Guid userId);
    }
}
