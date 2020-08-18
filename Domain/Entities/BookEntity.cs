using System.Collections.Generic;
using System.Reflection.Emit;

namespace Domain.Entities
{
    public class BookEntity : EntityBase
    {
        public ICollection<CategoryEntity> Categories { get; set; }
        public string Name { get; set; }
        public int PagesNumber { get; set; }
        public int Year { get; set; }

    }
}
