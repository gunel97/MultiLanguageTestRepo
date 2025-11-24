using Microsoft.AspNetCore.Mvc;
using MultiLanguageTest.AdminMvc.Models;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.UI.Services.Abstracts;

namespace MultiLanguageTest.AdminMvc.ViewComponents
{
    public class LanguageViewComponent : ViewComponent
    {
        private readonly ILanguageService _languageService;
        private readonly ICookieService _cookieService;

        public LanguageViewComponent(ILanguageService languageService, ICookieService cookieService)
        {
            _languageService = languageService;
            _cookieService = cookieService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageService.GetAllAsync();
            var selectedLanguage = await _cookieService.GetLanguageAsync();
            var headerViewModel = new HeaderViewModel
            {
                Languages = languages,
                SelectedLanguage = selectedLanguage
            };

            return View(headerViewModel);
        }
    }
}
