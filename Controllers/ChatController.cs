using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class ChatController: Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}