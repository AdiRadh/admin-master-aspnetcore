using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class ComponentController: Controller
    {
        public IActionResult Cards()
        {
            return View();
        }
        public IActionResult Lists()
        {
            return View();
        }
    }
}