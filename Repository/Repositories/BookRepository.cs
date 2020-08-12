using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Repository.Repositories
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
        public bool UpdateList(IEnumerable<BookEntity> books)
        {
            throw new System.NotImplementedException();
        }
    }
}
