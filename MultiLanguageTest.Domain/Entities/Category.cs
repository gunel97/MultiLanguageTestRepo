using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class Category : Entity
    {
        public required string Test { get; set; } 
        public List<CategoryTranslation>? CategoryTranslations { get; set; }
        public List<Product>? Products { get; set; }
    }

    public class CategoryTranslation : Entity
    {
        public required string Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
    }

    public class Product : Entity
    {
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<ProductTranslation>? ProductTranslations { get; set; }
    }

    public class ProductTranslation : Entity
    {
        public required string Name { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
    }

    public class Language : Entity
    {
        public required string Name { get; set; }
        public required string IsoCode { get; set; }
    }
}
