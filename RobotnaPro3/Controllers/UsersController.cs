using Microsoft.AspNetCore.Mvc;
using RobotnaPro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Controllers
{
    public class UsersController : Controller
    {
        public RobotnaDbContext sd;
        public UsersController(RobotnaDbContext _sd)

        {
            sd = _sd;
        }
        public IActionResult Index()
        {
            return View(sd.Users);
        }
        public IActionResult CreatUser()
        { return View(); }
        
   [HttpPost]
        public IActionResult CreatUser(User Use)
        {
            sd.Users.Add(Use);
            sd.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var data = sd.Users.Find(id);
            return View(data);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = sd.Users.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(User Use)
        {
            sd.Users.Update(Use);
            sd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int UserId)
        {
            var data = sd.Products.Find(UserId);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int UserId, User user)
        {
            var data = sd.Users.Find(user);
            sd.Users.Remove(data);
            sd.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
