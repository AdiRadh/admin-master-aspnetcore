using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class TableController: Controller
    {
        public IActionResult SimpleTables()
        {
            return View();
        }
        public IActionResult DataTables()
        {
            return View();
        }
    }
}