using MultiLanguageTest.Application.ViewModels;

namespace MultiLanguageTest.AdminMvc.Models
{
    public class HeaderViewModel
    {
        public List<LanguageViewModel>? Languages { get; set; }
        public LanguageViewModel? SelectedLanguage { get; set; }
    }
}
