using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IBookService : IServiceBase<BookEntity>
    {
        bool UpdateList(IEnumerable<BookEntity> books);
    }
}
