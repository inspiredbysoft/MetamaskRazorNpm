using Microsoft.AspNetCore.Mvc;

namespace MetamaskRazor_Test2.Controllers
{
    public class MetamaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
