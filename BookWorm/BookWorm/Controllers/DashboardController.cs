using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using BookWorm.ApplicationLogic.Services;
using BookWorm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ReviewService reviewService;
        private readonly CommentService commentService;
        private readonly ReplyService replyService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserServices userService;


        public DashboardController(ReviewService reviewService, CommentService commentService, ReplyService replyService, UserManager<IdentityUser> userManager,
            UserServices userService)
        {
            this.reviewService = reviewService;
            this.commentService = commentService;
            this.replyService = replyService;
            this.userManager = userManager;
            this.userService = userService;
        }

        public ActionResult DashboardView()
        {
            try
            {
                var reviews = reviewService.GetAll();
                var comments = commentService.GetAll();
                
                ICollection<Review> ReviewsByUser = new Collection<Review>();

                var userEmail = userManager.GetUserName(User);
                var user = userService.GetUserByUserEmail(userEmail);
                var followers = userService.GetUser_Followers(user);
                foreach (var item in reviews)
                {
                    foreach (var item1 in followers)
                    {
                        if (item.User == item1.User)
                            ReviewsByUser.Add(item);
                    }
                }


                return View(new DashboardViewModel { Reviews = ReviewsByUser, Comments = comments });
            } 
            catch(EntityNotFoundException)
            {
               return NotFound();
            }
            catch(Exception)
            {
                return BadRequest("Invalid request received");
            }
        }

        [HttpGet]
        public ActionResult AddComment()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult AddComment([FromForm] AddCommentViewModel model)
        {
            var userEmail = userManager.GetUserName(User);
            var user = userService.GetUserByUserEmail(userEmail);
            commentService.AddComment(model.text, model.reviewTitle, user);
            return View("DashboardView", "Dashboard");
        }

        [HttpGet]
        public ActionResult AddReply()
        {
            return View();
        }

        public IActionResult AddReply([FromForm] AddReplyViewModel model)
        {
            var userEmail = userManager.GetUserName(User);
            var user = userService.GetUserByUserEmail(userEmail);
            replyService.AddReply(model.text, user);
            return View("AddReply", "DashboardView");
        }

        [HttpGet]
        public ActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview([FromForm] AddReviewViewModel model)
        {
            var userEmail = userManager.GetUserName(User);
            var user = userService.GetUserByUserEmail(userEmail);
            reviewService.AddReview(model.bookName, model.authorName, model.text, model.Title, user);
            return View("DashboardView", "Dashboard");
        }

        [HttpGet]
        public IActionResult DeleteReview([FromRoute]Guid reviewId)
        {
            var deleteVM = new DeleteReviewViewModel { ReviewId = reviewId };

            return View(deleteVM);
        }

        [HttpPost]
        public IActionResult DeleteReview(DeleteReviewViewModel model)
        {
            reviewService.DeleteReview(model.ReviewId);
            return Redirect(Url.Action("AllReviews", "YourBooks"));
        }
    }
}
