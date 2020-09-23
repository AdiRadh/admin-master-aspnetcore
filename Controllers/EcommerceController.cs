using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult EditProduct()
        {
            return View();
        }

    }
}
