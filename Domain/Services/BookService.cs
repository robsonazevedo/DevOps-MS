using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class BookService : ServiceBase<BookEntity>, IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository) : base(repository) {
            _repository = repository;
        }
    }
}
