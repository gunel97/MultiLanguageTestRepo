using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.ViewModels
{
    public class CategoryTranslationViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class LanguageViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? IsoCode { get; set; }
    }

    public class ProductTranslationViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel? Product { get; set; }
        public int LanguageId { get; set; }
        public LanguageViewModel? LanguageViewModel { get; set; }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public CategoryViewModel? Category { get; set; }
    }

    public class TopHeaderViewModel
    {
        public List<LanguageViewModel>? Languages { get; set; }
        public LanguageViewModel? SelectedLanguage { get; set; }
    }
    public class LanguageCreateViewModel
    {

    }

    public class ProductTranslationCreateViewModel
    {
        public string Name { get; set; } = null!;
        public int ProductId { get; set; }
        public ProductViewModel? Product { get; set; }
        public int LanguageId { get; set; }
        public List<SelectListItem>? Languages { get; set; }
        public string? Message { get; set; }
    }

    public class ProductCreateViewModel
    {
        public int CategoryId { get; set; }
        public List<SelectListItem>? CategoryList { get; set; }
    }

    public class CategoryCreateViewModel
    {

    }

}
