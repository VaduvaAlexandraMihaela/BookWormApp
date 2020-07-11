using BookWorm.ApplicationLogic.Exceptions;
using BookWorm.ApplicationLogic.Services;
using BookWorm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWorm.Controllers
{
    public class SearchUsersController : Controller
    {
        private readonly UserServices userService;
        private readonly UserManager<IdentityUser> userManager;

        public SearchUsersController(UserServices userServices, UserManager<IdentityUser> userManager)
        {
            this.userService = userServices;
            this.userManager = userManager;
        }

       
        public ActionResult SearchUser(string userName)
        {
            if(userName == null)
            {
                var users = userService.GetAll();
                return View(new SearchUsersViewModel { Users = users });
            }
            try
            {
                var users = userService.GetUsersByName(userName);
                return View( new SearchUsersViewModel{ Users = users});
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

        public ActionResult ProfileFollower(string followerFirstName)
        {
            try
            {
                var follower = userService.GetFollowerByFirstName(followerFirstName);
                return View(new FollowerProfileViewModel { Follower = follower }); 
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
        public IActionResult AddFollower(Guid id)
        {
            var addFVM = new AddFollowerViewModel()
            {
                id = id
            };

            return View(addFVM);
        }

        [HttpPost]
        public IActionResult AddFollower([FromForm]AddFollowerViewModel model)
        {
            var user = userService.GetUserById(model.id);

            userService.AddFollower(user);

            return RedirectToAction("SearchUser", "SearchUsers");
        }
        
    }
}
