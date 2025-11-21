using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.ViewModels;
using MultiLanguageTest.Domain.Entities;
using MultiLanguageTest.Persistence.DataContext;
using MultiLanguageTest.Persistence.Implementation;

namespace MultiLanguageTest.Application.Services.Implementations
{
    public class ProductTranslationManager : CrudManager<ProductTranslationViewModel, ProductTranslation, ProductTranslationCreateViewModel>, IProductTranslationService
    {
        private readonly EfRepositoryBase<ProductTranslation, AppDbContext> _repository;
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;

        public ProductTranslationManager(EfRepositoryBase<ProductTranslation, AppDbContext> repository, IMapper mapper, IProductService productService, ILanguageService languageService) : base(repository, mapper)
        {
            _repository = repository;
            _productService = productService;
            _languageService = languageService;
        }

        public async Task<ProductTranslationCreateViewModel> GetProductTranslationCreateViewModelAsync(int productId)
        {
            var languageSelectListItems = new List<SelectListItem>();
            var product = await _productService.GetAsync(productId);
            var languages = await _languageService.GetAllAsync();

            foreach (var language in languages)
            {
                if ((await _repository.GetAsync(x => x.LanguageId == language.Id && x.ProductId == productId)) != null)
                    continue;

                languageSelectListItems.Add(new SelectListItem(language.Name, language.Id.ToString()));
            }

            var createViewModel = new ProductTranslationCreateViewModel
            {
                Product = product,
                Languages = languageSelectListItems
            };

            return createViewModel;
        }
    }

}
