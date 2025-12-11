using System.Diagnostics;
using Entity_framework.Data;
using Entity_framework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Entity_framework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
