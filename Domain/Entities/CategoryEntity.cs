using System.Collections.Generic;

namespace Domain.Entities
{
    public class CategoryEntity : EntityBase
    {
        public ICollection<BookEntity> Books { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}