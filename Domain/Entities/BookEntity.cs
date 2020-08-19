using System.Collections.Generic;

namespace Domain.Entities
{
    public class BookEntity : EntityBase
    {
        public BookEntity() => Categories = new HashSet<CategoryEntity>();

        public ICollection<CategoryEntity> Categories { get; set; }
        public string Name { get; set; }
        public int PagesNumber { get; set; }
        public int Year { get; set; }

    }
}
