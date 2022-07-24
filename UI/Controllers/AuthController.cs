using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            TempData["error"] = null;
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }
        [HttpPost]
        public IActionResult Login(string Username, string password)
        {
            if (Username == null || password == null)
            {
                TempData["error"] = "تمام فیلد ها ضروری اند.";
                return View("Index");
            }


            if (Username != "StudentAdmin" || password != "OJHD*39y")
            {
                TempData["error"] = "نام کاربری یا رمز عبور اشتباه است.";
                return View("Index");
            }

            List<Claim> claims = new List<Claim>()
            {
                new Claim("LoggedIn","done"),
                new Claim(ClaimTypes.NameIdentifier,"1"),
                new Claim(ClaimTypes.Name,Username),
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties()
            {
                IsPersistent = true
            };
            HttpContext.SignInAsync(claimPrincipal, properties);

            return Redirect("/");
        }
    }
}
