using Microsoft.AspNetCore.Mvc;

namespace MVCCalculator.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
