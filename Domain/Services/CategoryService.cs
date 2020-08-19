using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CategoryService : ServiceBase<CategoryEntity>, ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
