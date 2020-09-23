using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class HelpController: Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
}