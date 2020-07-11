using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using BookWorm.ApplicationLogic.Services;
using BookWorm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Controllers
{
    public class YourAuthorsController : Controller
    {
        private readonly AddAuthorService authorService;
        private readonly ReviewService reviewService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserServices userService;

        public YourAuthorsController(AddAuthorService authorService, ReviewService reviewService, UserManager<IdentityUser> userManager,
            UserServices userService)
        {
            this.authorService = authorService;
            this.reviewService = reviewService;
            this.userManager = userManager;
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor([FromForm]AddAuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var userEmail = userManager.GetUserName(User);
            var user = userService.GetUserByUserEmail(userEmail);
            authorService.AddAuthor(model.authorName, user);
            return View("YourAuthorsView","YourAuthors");
        }

        [HttpGet]
        public IActionResult DeleteAuthor([FromRoute]Guid authorId)
        {
            var deleteVM = new DeleteAuthorViewModel { authorId = authorId };

            return View(deleteVM);
        }

        [HttpPost]
        public IActionResult DeleteAuthor(DeleteAuthorViewModel model)
        {
            authorService.DeleteAuthor(model.authorId);
            return Redirect(Url.Action("YourAuthorsView", "YourAuthors"));
        }

        public ActionResult YourAuthorsView()
        {
            try
            {
                var authors = authorService.GetAll();
                var reviews = reviewService.GetAll();
                ICollection<Review> ReviewsByUser = new Collection<Review>();
                ICollection<Author> AuthorsByUser = new Collection<Author>();

                var userEmail = userManager.GetUserName(User);
                var user = userService.GetUserByUserEmail(userEmail);

                foreach (var item in reviews)
                {
                    if (item.User == user)
                        ReviewsByUser.Add(item);
                }

                foreach(var item in authors)
                {
                    if (item.User == user)
                        AuthorsByUser.Add(item);
                }

                return View(new YourAuthorsViewModel { Reviews = ReviewsByUser, Authors = AuthorsByUser });
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
    }
}
