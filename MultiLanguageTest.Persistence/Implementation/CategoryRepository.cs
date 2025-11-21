using MultiLanguageTest.Domain.Entities;
using MultiLanguageTest.Persistence.Abstraction;
using MultiLanguageTest.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Persistence.Implementation
{
    public class CategoryRepository : EfRepositoryBase<Category, AppDbContext>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }

    public class CategoryTranslationRepository : EfRepositoryBase<CategoryTranslation, AppDbContext>, ICategoryTranslationRepository
    {
        public CategoryTranslationRepository(AppDbContext context) : base(context)
        {
        }
    }

    public class LanguageRepository : EfRepositoryBase<Language, AppDbContext>, ILanguageRepository
    {
        public LanguageRepository(AppDbContext context) : base(context)
        {
        }
    }

    public class ProductRepository : EfRepositoryBase<Product, AppDbContext>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }

    public class ProductTranslationRepository : EfRepositoryBase<ProductTranslation, AppDbContext>, IProductTranslationRepository
    {
        public ProductTranslationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
