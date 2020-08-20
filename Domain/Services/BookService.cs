using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Services
{
    public class BookService : ServiceBase<BookEntity>, IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository) : base(repository) {
            _repository = repository;
        }

        public IEnumerable<BookEntity> GetByCategory(string category)
        {
            return _repository.GetByCategory(category);
        }
    }
}
