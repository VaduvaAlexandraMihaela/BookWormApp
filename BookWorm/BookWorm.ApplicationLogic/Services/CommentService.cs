using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace BookWorm.ApplicationLogic.Services
{
   public class CommentService
    {
        private ICommentRepository commentRepository;
        private IReviewRepository reviewRepository; 

        public CommentService(IReviewRepository reviewRepository, ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
            this.reviewRepository = reviewRepository;
        }

        public IEnumerable<Comment> GetAll()
        {
            return commentRepository.GetAll();
        }

        public IEnumerable<Comment> GetCommentsByReviewId(Guid ReviewId)
        {
            var review = reviewRepository.GetReviewbyReviewId(ReviewId);
            var comments = new List<Comment>();
            var allcomments = commentRepository.GetAll(); 
            foreach(var item in allcomments)
            {
                if (item.Review == review)
                    comments.Add(item);
            }

            return comments;
        }

        public void AddComment(string text, string reviewTitle, User user)
        {
            var review = reviewRepository.GetReviewByReviewName(reviewTitle);
            commentRepository.Add(new Comment { Id = Guid.NewGuid(), Text = text, Review = review, User = user }); 
        }
    }
}
