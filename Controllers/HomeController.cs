using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab25.Models;

namespace Lab25.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Purchase()
        {
            return View();
        }

        public IActionResult Recipte(Purchase p)
        {
            ViewBag.Name = p.Name;
            ViewBag.Price = p.Price;
            ViewBag.Quantity = p.Quantity;
            ViewBag.Description = p.Description;
            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreditCard(Purchase p)
        {
            ViewBag.Price = p.Price;
            ViewBag.Quantity = p.Quantity;
            ViewBag.Description = p.Description;
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
