using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.Services.Implementations
{
    public class StringLocalizerService
    {
        private readonly IStringLocalizer _stringLocalizer;

        public StringLocalizerService(IStringLocalizerFactory stringLocalizerFactory)
        {
            _stringLocalizer = stringLocalizerFactory.Create("SharedResources", "MultiLanguageTest.Mvc");
        }

        public string GetValue(string key)
        {
            
            var test  =  _stringLocalizer.GetString(key);
            return test;
        }
    }
}
