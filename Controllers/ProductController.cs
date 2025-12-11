using Microsoft.AspNetCore.Mvc;

namespace Entity_framework.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
