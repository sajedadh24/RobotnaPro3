using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RobotnaPro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Controllers
{
    public class AccountController : Controller
    {
        private readonly RobotnaDbContext db;
        public AccountController(RobotnaDbContext _db)
        {
            db = _db;
        }
        public IActionResult Register()
        {
            ViewBag.myRoles = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("SuccesRegiter");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var chkUser = db.Users.Where(x => x.UserName == user.UserName && x.Password==user.Password);
            if (chkUser.Any())
            {
                if (chkUser.SingleOrDefault().RoleId==1)
                {
                    return RedirectToAction("Index", "Users");

                }
                return RedirectToAction("Index", "Products");
            }
            ViewBag.err = "Inalid User or Password";
            return View(user);

        }
        public IActionResult SuccesRegiter()
        {
            return View();
        }
    }

}
