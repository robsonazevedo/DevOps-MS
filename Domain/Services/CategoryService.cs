using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CategoryService : ServiceBase<CategoryEntity>, ICategoryService
    {
        public CategoryService(IRepositoryBase<CategoryEntity> repository) : base(repository) { }
    }
}
