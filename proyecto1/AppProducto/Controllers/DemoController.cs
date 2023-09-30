using Microsoft.AspNetCore.Mvc;

namespace AppProducto.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hola desde el controlador";
            return View();
        }
    }
}