using Microsoft.AspNetCore.Mvc;
using RobotnaPro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Controllers
{
    public class CategoriesController : Controller
    {

        private RobotnaDbContext _db;
        public CategoriesController(RobotnaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
