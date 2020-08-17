using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class BookCategoryService : ServiceBase<BookCategoryEntity>, IBookCategoryService
    {
        private readonly IBookCategoryRepository _repository;

        public BookCategoryService(IBookCategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}