using Microsoft.AspNetCore.Mvc;
using RobotnaPro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaPro3.Controllers
{
    public class ProductsController : Controller
    {
        public RobotnaDbContext db;
        public ProductsController(RobotnaDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.Products);
        }
        public IActionResult GreatProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GreatProduct(Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
       [HttpPost]
       public IActionResult Edit(Product pro)
        {
            db.Products.Update(pro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Delete(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int ProductId , Product pro)
        {
            var data = db.Products.Find(pro.ProductId);
            db.Products.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");


        }




    }
}
