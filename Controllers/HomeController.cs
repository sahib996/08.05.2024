using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaContext _context;

        public HomeController(ProniaContext context)
        {
               _context = context;
        }
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.Categories.ToListAsync());
        }

        private IActionResult View(object value)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Contanct()
        {
            return View();
        }
        public async Task<IActionResult> Shop()
        {
            return View();
        }
        public async Task<IActionResult> About ()
        {
            return View();
        }
    }
}
