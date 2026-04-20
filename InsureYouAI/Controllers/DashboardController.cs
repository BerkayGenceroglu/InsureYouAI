using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardPage()
        {
            ViewBag.Controller = "Dashboard";
            ViewBag.Page = "İstatistik-Karşılaştırma-Tahminler";
            return View();
        }
    }
}
