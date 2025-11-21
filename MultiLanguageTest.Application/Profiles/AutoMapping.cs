using AutoMapper;
using MultiLanguageTest.Application.ViewModels;
using MultiLanguageTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            CreateMap<LanguageViewModel, Language>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryTranslations!.FirstOrDefault() == null ? "" : src.CategoryTranslations!.FirstOrDefault()!.Name)).ReverseMap();
            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductTranslations!.FirstOrDefault() == null ? "" : src.ProductTranslations!.FirstOrDefault()!.Name))
               .ReverseMap();
            CreateMap<Product, ProductCreateViewModel>().ReverseMap();
            CreateMap<CategoryTranslationViewModel, CategoryTranslation>().ReverseMap();
            CreateMap<ProductTranslationViewModel, ProductTranslation>().ReverseMap();
             CreateMap<ProductTranslationCreateViewModel, ProductTranslation>().ReverseMap();
        }
    }
}
