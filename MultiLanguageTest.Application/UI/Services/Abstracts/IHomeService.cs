using MultiLanguageTest.Application.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.UI.Services.Abstracts
{
    public interface IHomeService
    {
        Task<HomeViewModel> GetHomeViewModelAsync();
    }
}
