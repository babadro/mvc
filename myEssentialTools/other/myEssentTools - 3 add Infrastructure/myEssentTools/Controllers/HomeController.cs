﻿using System.Collections.Generic;
using myEssentTools.Models;
using System.Web.Mvc;
using Ninject;

namespace myEssentTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products = {
                                        new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                                        new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                                        new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                                        new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                                     };
        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            /* old code
            
             IValueCalculator calc = new LinqValueCalculator(); 
            
             */
            /* old code 2:
             
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            
             */
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }

    }
}