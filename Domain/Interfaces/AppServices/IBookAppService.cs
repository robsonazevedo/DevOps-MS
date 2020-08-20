using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.AppServices
{
    public interface IBookAppService : IAppServiceBase<BookEntity>
    {
        IEnumerable<BookEntity> GetByCategory(string category);
    }
}
