using MultiLanguageTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.UI.Services.Abstracts
{
    public interface ICookieService
    {
        Task<LanguageViewModel> GetLanguageAsync();
        //Task<CurrencyViewModel> GetCurrencyAsync();
       // void AddBrowserId();
        //string GetBrowserId();
    }
}
