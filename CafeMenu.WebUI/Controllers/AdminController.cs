using Microsoft.AspNetCore.Mvc;

namespace TaskManager.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
