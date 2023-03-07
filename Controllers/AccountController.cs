using azmoooon.Models;
using Microsoft.AspNetCore.Mvc;

namespace azmoooon.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string mobile, string email)
        {
            var user = new User();
            user.Email = email;
            user.Mobile= mobile;
            return View();
        }
    }
}
