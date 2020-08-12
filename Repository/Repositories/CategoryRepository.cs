using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class CategoryRepository : RepositoryBase<CategoryEntity>, ICategoryRepository
    {
    }
}
