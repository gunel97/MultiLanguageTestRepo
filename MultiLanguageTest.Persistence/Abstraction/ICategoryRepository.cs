using MultiLanguageTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Persistence.Abstraction
{
    public interface ICategoryRepository : IRepositoryAsync<Category>
    {
    }

    public interface ICategoryTranslationRepository : IRepositoryAsync<CategoryTranslation>
    {
    }

    public interface ILanguageRepository : IRepositoryAsync<Language>
    {
    }

    public interface IProductRepository : IRepositoryAsync<Product>
    {
    }

    public interface IProductTranslationRepository : IRepositoryAsync<ProductTranslation>
    {
    }
}
