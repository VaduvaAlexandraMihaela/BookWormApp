using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookWorm.Models;
using BookWorm.ApplicationLogic.Services;
using Microsoft.AspNetCore.Identity;
using BookWorm.ApplicationLogic.Exceptions;

namespace BookWorm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserServices userService;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, UserServices userService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.userService = userService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            try
            {
                var userEmail = userManager.GetUserName(User);
                var user = userService.GetUserByUserEmail(userEmail);
                var books = userService.GetFollowersBooks(user);
                var authors = userService.GetFollowersAuthors(user);

                return View(new HomePageViewModel { books = books, authors = authors });
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
