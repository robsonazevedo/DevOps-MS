using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class CategoryAppService : AppServiceBase<CategoryEntity>, ICategoryAppService
    {
        private readonly ICategoryService _service;

        public CategoryAppService(ICategoryService service) : base(service)
        {
            _service = service;
        }
    }
}
