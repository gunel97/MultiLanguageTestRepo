using Microsoft.AspNetCore.Mvc;

namespace MultiLanguageTest.AdminMvc.Controllers
{
    public class DashboardController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
