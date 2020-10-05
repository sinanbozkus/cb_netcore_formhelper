using AspNetCore_Giris.Models;
using AspNetCore_Giris.Services;
using AspNetCore_Giris.Types;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using FormHelper;

namespace AspNetCore_Giris.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index([FromServices]UserService userService)
        {
            // var userService = HttpContext.RequestServices.GetService<UserService>();
            // public IActionResult Index([FromServices]UserService userService)

            ViewBag.Users = _userService.GetUsers();
            return View();
        }

        [HttpPost]
        [FormValidator]
        public IActionResult Save(UserFormViewModel viewModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Users = _userService.GetUsers();
            //    return View("Index", viewModel);
            //}

            if(viewModel.FirstName == "AHMET")
            {
                return FormResult.CreateErrorResult("Ahmet yazılamaz.");
            }

            _userService.AddUser(new RegisteredUser
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName
            });

            //return RedirectToAction("Index");
            return FormResult.CreateSuccessResult("Kişi kayıt edildi, lütfen bekleyiniz", Url.Action("Index"));
        }
    }
}
