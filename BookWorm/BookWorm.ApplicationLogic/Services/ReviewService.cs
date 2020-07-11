using BookWorm.ApplicationLogic.Abstractions;
using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorm.ApplicationLogic.Services
{
    public class ReviewService
    {
        private IReviewRepository reviewRepository;
        private IBookRepository bookRepository;
        private IAuthorRepository authorRepository;
        public int nrReview;

        public ReviewService(IReviewRepository reviewRepository, IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this.reviewRepository = reviewRepository;
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }


        public Review GetReviewbyUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty; 

            if(!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var review = reviewRepository.GetReviewbyUserId(userIdGuid); 

            if(review == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return review;
        }

        public IEnumerable<Review> GetAll()
        {
            return reviewRepository.GetAll();
        }


        public void AddReview( string bookName, string authorName, string text, string Title, User user )
        { 
           
            var book = bookRepository.GetBookByName(bookName);
            var author = authorRepository.GetAuthorByName(authorName);

            reviewRepository.Add(new Review() { Id = Guid.NewGuid(), Text = text, Book = book,  Author = author, Title = Title, User = user });
            nrReview++;
        }

        public void DeleteReview(Guid reviewId)
        {
            var review = reviewRepository.GetReviewbyReviewId(reviewId);
            reviewRepository.Delete(review);
        }

    }
}
