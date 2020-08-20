using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IBookService : IServiceBase<BookEntity>
    {
        IEnumerable<BookEntity> GetByCategory(string category);
    }
}
