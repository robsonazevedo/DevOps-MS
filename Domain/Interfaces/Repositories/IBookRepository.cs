using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IBookRepository : IRepositoryBase<BookEntity>
    {
        IEnumerable<BookEntity> GetByCategory(string category);
    }
}
