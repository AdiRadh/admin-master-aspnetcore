using Microsoft.AspNetCore.Mvc;
namespace dotNetCoreMVC.Controllers
{
    public class ChartController: Controller
    {
        public IActionResult ChartJS()
        {
            return View();
        }
        public IActionResult AmCharts()
        {
            return View();
        }
        
    }
}