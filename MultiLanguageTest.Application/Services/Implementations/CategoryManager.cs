using AutoMapper;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.ViewModels;
using MultiLanguageTest.Domain.Entities;
using MultiLanguageTest.Persistence.DataContext;
using MultiLanguageTest.Persistence.Implementation;

namespace MultiLanguageTest.Application.Services.Implementations
{
    public class CategoryManager : CrudManager<CategoryViewModel, Category, CategoryCreateViewModel>, ICategoryService
    {
        private readonly EfRepositoryBase<Category, AppDbContext> _repository;

        public CategoryManager(EfRepositoryBase<Category, AppDbContext> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }

}
