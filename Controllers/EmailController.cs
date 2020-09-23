using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class EmailController: Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}