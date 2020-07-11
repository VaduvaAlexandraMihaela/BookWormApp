using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Services
{
   public class ReplyService
    {
        private ICommentRepository commentRepository;
        private IReplyRepository replyRepository;

        public ReplyService(IReplyRepository replyRepository, ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
            this.replyRepository = replyRepository;
        }

        public IEnumerable<Reply> GetAll()
        {
            return replyRepository.GetAll(); 
        }

        public void AddReply(string text, User user)
        {
            replyRepository.Add(new Reply { Id = Guid.NewGuid(), Text = text, User = user });
        }
    }
}
