using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetCoreMVC.Models;

namespace dotNetCoreMVC.Controllers
{
    public class AuthenticationController:Controller
    {
     public IActionResult Login()
        {
            return View();
        }
    public IActionResult Signup()
        {
            return View();
        }
    public IActionResult ForgotPassword()
        {
            return View();
        }
    public IActionResult ResetPassword()
        {
            return View();
        }   
    }
}