using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Controllers
{
    public class MainController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
     
        [HttpPost]

        public IActionResult Add(Product product, User user, IFormCollection frm)
        {
            db.Users.Add(user);
            db.Products.Add(product);
            Bill bill = new Bill();
            bill.BillNumber = frm["BillNumber"];
            bill.BillDate = frm["BillDate"];
            bill.Total =product.Quantity * product.UnitPrice;
            db.Bills.Add(bill);
            db.SaveChanges();
            ViewBag.Total =bill.Total+ "₺";
            return View();
        }
    }
}