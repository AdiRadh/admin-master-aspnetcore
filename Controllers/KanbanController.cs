using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class KanbanController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}