using Microsoft.EntityFrameworkCore;
using MultiLanguageTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Persistence.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public required DbSet<Language> Languages { get; set; }
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<CategoryTranslation> CategoriesTranslations { get; set; }
        public required DbSet<Product> Products { get; set; }
        public required DbSet<ProductTranslation> ProductTranslations { get; set; }
    }
}
