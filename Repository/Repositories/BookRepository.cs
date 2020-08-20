using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
        public IEnumerable<BookEntity> GetByCategory(string category)
        {
            return Context.Set<BookEntity>().Where(b => b.Categories.Any(c => c.Name.Contains(category)));
        }
    }
}
