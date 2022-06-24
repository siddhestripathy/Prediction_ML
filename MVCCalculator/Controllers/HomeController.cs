using Microsoft.AspNetCore.Mvc;
using MVCCalculator.Models;
using System.Diagnostics;

namespace MVCCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Calculator cal)
        {
            return View(cal);
        }

        [HttpPost]
   public IActionResult Index(Calculator cal,string cmd)
        {
            int a, b;
            a = cal.value1;
            b = cal.value2;
            if (cal.calculate == "add")
            {
                cal.result = a + b;
            }
            else if (cal.calculate == "sub")
            {
                cal.result = a - b;
            }
            else if (cal.calculate == "mul")
            {
                cal.result = a * b;
            }
            else
            {
                cal.result = a / b;
            }
            // ViewBag.res = cal.result;
            cal.result = cal.result;
            return View(cal);
        }
    
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}