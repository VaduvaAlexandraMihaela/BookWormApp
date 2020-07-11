using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using BookWorm.ApplicationLogic.Services;
using BookWorm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Controllers
{
    public class YourBooks : Controller
    {
        private readonly ReviewService reviewService;
        private readonly AddBookService bookService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserServices userService;


        public YourBooks(ReviewService reviewService, AddBookService bookService, UserManager<IdentityUser> userManager, 
            UserServices userService)
        {
            this.reviewService = reviewService;
            this.bookService = bookService;
            this.userManager = userManager;
            this.userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllReviews()
        {
            try
            {
                var reviews = reviewService.GetAll();

                return View(new GetAllReviewsViewModel { Reviews = reviews });
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest("Invalid request received");
            }
        }

        public ActionResult YourReviews()
        {
            try
            {
                var reviews = reviewService.GetAll();

                return View(new GetAllReviewsViewModel { Reviews = reviews });
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

        public ActionResult YourBooksView()
        {
            try
            {
                var books = bookService.GetAll();
                var reviews = reviewService.GetAll();
                ICollection<Review> ReviewsByUser = new Collection<Review>();
                ICollection<Book> BooksByUser = new Collection<Book>();

                var userEmail = userManager.GetUserName(User);
                var user = userService.GetUserByUserEmail(userEmail);

                foreach (var item in reviews)
                {
                    if (item.User == user)
                        ReviewsByUser.Add(item);
                }

                foreach (var item in books)
                {
                    if (item.User == user)
                        BooksByUser.Add(item);
                }
                return View(new YourBooksViewModel { Reviews = ReviewsByUser, Books = BooksByUser });
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest("Invalid request received");
            }
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook([FromForm]AddBookViewModel model)
        {
            var userEmail = userManager.GetUserName(User);
            var user = userService.GetUserByUserEmail(userEmail);
            bookService.AddBook(model.bookName, user);

            return View("YourBooksView", "YourBooks");
        }

        [HttpGet]
        public IActionResult DeleteBook([FromRoute]Guid bookId)
        {
            var deleteVM = new DeleteBookViewModel { bookId = bookId };

            return View(deleteVM);
        }

        [HttpPost]
        public IActionResult DeleteBook(DeleteBookViewModel model)
        {
            bookService.DeleteBook(model.bookId);
            return Redirect(Url.Action("YourBooksView", "YourBooks"));
        }
    }
}
