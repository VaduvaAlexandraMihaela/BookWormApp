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
    public class RegisterController : Controller
    {
        private readonly UserServices userService; 

        public RegisterController(UserServices userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] AddUserModel model)
        {
            var user = new IdentityUser { UserName = model.FirstName, Email = model.Email };
            userService.AddUser(model.FirstName, model.LastName, model.Email, model.Password);
            return View("Register", "Index");
        }

    }
}
