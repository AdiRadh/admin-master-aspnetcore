using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class FormController: Controller
    {
        public IActionResult Layouts()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
        public IActionResult Validations()
        {
            return View();
        }   
    }
}