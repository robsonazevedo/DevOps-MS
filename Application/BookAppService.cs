using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class BookAppService : AppServiceBase<BookEntity>, IBookAppService
    {
        private readonly IBookService _service;

        public BookAppService(IBookService service) : base(service)
        {
            _service = service;
        }
    }
}
