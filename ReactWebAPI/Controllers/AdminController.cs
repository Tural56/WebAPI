using Microsoft.AspNetCore.Mvc;

namespace ReactWebAPI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
