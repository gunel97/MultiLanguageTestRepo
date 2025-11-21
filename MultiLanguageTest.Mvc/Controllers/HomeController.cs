using Microsoft.AspNetCore.Mvc;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.UI.Services.Abstracts;
using MultiLanguageTest.Mvc.Models;
using System.Diagnostics;

namespace MultiLanguageTest.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService, ILanguageService languageService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var homeViewModel = await _homeService.GetHomeViewModelAsync();

            return View(homeViewModel);
        }
    }
}
