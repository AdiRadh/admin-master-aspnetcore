using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class UIElementController: Controller
    {
        public IActionResult Alerts()
        {
            return View();
        }
        public IActionResult Accordions()
        {
            return View();
        }
        public IActionResult Badges()
        {
            return View();
        }
        public IActionResult Buttons()
        {
            return View();
        }
        public IActionResult Spinners()
        {
            return View();
        }
        public IActionResult ProgressBars()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            return View();
        }
        public IActionResult Tooltips()
        {
            return View();
        }
    }
}