using Domain.Entities;
using Domain.Interfaces.AppServices;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Application
{
    public class BookAppService : AppServiceBase<BookEntity>, IBookAppService
    {
        private readonly IBookService _service;

        public BookAppService(IBookService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<BookEntity> GetByCategory(string category)
        {
            return _service.GetByCategory(category);
        }
    }
}
