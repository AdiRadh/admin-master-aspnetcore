using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class CalendarController: Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}