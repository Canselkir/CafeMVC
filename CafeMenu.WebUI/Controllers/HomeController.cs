using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.DataAccess.Concrete.EFCore;
using System.Xml;
using System.Data;

namespace TaskManager.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskManagerContext _context;

        public HomeController(TaskManagerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = _context.Products.Include(p => p.Category).Where(t=>!t.IsDeleted).OrderByDescending(t=>t.CreatedDate);
            return View(await products.ToListAsync());
        }

        [HttpPost]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Search(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                var products = _context.Products.Where(t => t.ProductName.ToLower().Contains(searchText.ToLower())).ToListAsync();
                return View(await products);
            }
            else
            {
                return View();
            }

        }
    }
}
