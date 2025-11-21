using AutoMapper;
using MultiLanguageTest.Application.Services.Abstracts;
using MultiLanguageTest.Application.ViewModels;
using MultiLanguageTest.Domain.Entities;
using MultiLanguageTest.Persistence.DataContext;
using MultiLanguageTest.Persistence.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageTest.Application.Services.Implementations
{
    public class LanguageManager : CrudManager<LanguageViewModel, Language, LanguageCreateViewModel>, ILanguageService
    {
        private readonly EfRepositoryBase<Language, AppDbContext> _languageRepository;

        public LanguageManager(EfRepositoryBase<Language, AppDbContext> languageRepository, IMapper mapper) : base(languageRepository, mapper)
        {
            _languageRepository = languageRepository;
        }
    }
}
