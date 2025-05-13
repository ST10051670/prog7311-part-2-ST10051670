using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Data;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AccountController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new User //Creating new user
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                    Role = model.Role,
                    PhoneNumber = model.Role == "Farmer" ? model.PhoneNumber : "",  
                    Location = model.Role == "Farmer" ? model.Location : "" 
                };

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = _dbContext.Users
                            .FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    HttpContext.Session.SetString("UserEmail", user.Email);
                    HttpContext.Session.SetString("UserFullName", user.FullName);
                    HttpContext.Session.SetString("UserRole", user.Role); 

                    return RedirectToAction("Index", "Home"); 
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid email or password.");
                }
            }

            return View(model);
        }
    }
}
