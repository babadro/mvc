﻿using myEssentialTools1.Models;
using System.Web.Mvc;

namespace myEssentialTools1.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products = {
                                         new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                                     };

        public ActionResult Index()
        {
            LinqValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal CartTotal = cart.CalculateProductTotal();
            return View(CartTotal);
        }

    }
}
