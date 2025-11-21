using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using MultiLanguageTest.Application.Profiles;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.Services.Implementations;
using MultiLanguageTest.Application.UI.Services.Abstracts;
using MultiLanguageTest.Application.UI.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(
               options =>
               {
                   var supportedCultures = new List<CultureInfo>
                       {
                        new CultureInfo("en-US"),
                        new CultureInfo("az"),
                       };

                   options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");

                   options.SupportedCultures = supportedCultures;
                   options.SupportedUICultures = supportedCultures;

               });

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(config => config.AddProfile<AutoMapping>());

            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductTranslationService, ProductTranslationManager>();
            services.AddScoped<IHomeService, HomeManager>();
            services.AddScoped(typeof(ICrudService<,,>), typeof(CrudManager<,,>));
            //services.AddScoped<ICompareService, CompareManager>();
            services.AddScoped<ICookieService, CookieManager>();
           

            services.AddSingleton<StringLocalizerService>();

            return services;
        }
    }
}
