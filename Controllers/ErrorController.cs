using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class ErrorController : Controller
    {
        public new IActionResult NotFound()
        {
            return View();
        }

        public IActionResult InternalServer()
        {
            return View();
        }

    }
}