using MultiLanguageTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MultiLanguageTest.Application.ViewModels;

namespace MultiLanguageTest.Application.Services.Abstracts
{
    public interface ICrudService<TViewModel, TEntity, TCreateViewModel>
    {
        Task<TViewModel> GetAsync(int id);
        Task<TViewModel> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);
        Task<List<TViewModel>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null,
                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);
        Task<TViewModel> CreateAsync(TCreateViewModel createViewModel);
        Task Remove(int id);
    }

    public interface ICategoryService : ICrudService<CategoryViewModel, Category, CategoryCreateViewModel>
    {

    }

    public interface ICategoryTranslationService
    {
        Task<List<CategoryTranslationViewModel>> GetCategoryTranslationsAsync();
        Task<CategoryTranslationViewModel> GetCategoryTranslationAsync(int id);
    }

    public interface ILanguageService : ICrudService<LanguageViewModel, Language, LanguageCreateViewModel>
    {
    }

    public interface IProductService : ICrudService<ProductViewModel, Product, ProductCreateViewModel>
    {
        Task<ProductCreateViewModel> GetProductCreateViewModelAsync();
    }

    public interface IProductTranslationService : ICrudService<ProductTranslationViewModel, ProductTranslation, ProductTranslationCreateViewModel>
    {
        Task<ProductTranslationCreateViewModel> GetProductTranslationCreateViewModelAsync(int productId);
    }
}
