using MultiLanguageTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.UI.ViewModels
{
    public class HomeViewModel
    {
        public List<CategoryViewModel>? Categories { get; set; }
        public List<ProductViewModel>? Products { get; set; }
    }
}
