using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
    }
}
