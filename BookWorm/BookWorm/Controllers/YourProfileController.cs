using BookWorm.ApplicationLogic.Services;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BookWorm.ApplicationLogic.Data;
using BookWorm.ApplicationLogic.Exceptions;
using BookWorm.Models;

namespace BookWorm.Controllers
{
    public class YourProfileController: Controller
    {
        UserServices userService;
        private readonly UserManager<IdentityUser> userManager;


        public YourProfileController(UserServices userService, UserManager<IdentityUser> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }

        public ActionResult YourProfile()
        {
            try
            {
                string userEmail = userManager.GetUserName(User);
                var user = userService.GetUserByUserEmail(userEmail);
                string FirstName = user.FirstName;
                string LastName = user.LastName;
                string Email = userEmail;
                string Password = user.Password;
                return View(new YourProfileViewModel{ Email = userEmail, FirstName = FirstName, LastName = LastName, Password = Password });
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
