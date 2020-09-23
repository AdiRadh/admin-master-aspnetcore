using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult DefaultList()
        {
            return View();
        }
        public IActionResult DataTableList()
        {
            return View();
        }
        public IActionResult UserCard()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}