namespace Domain.Entities
{
    public class BookCategoryEntity : EntityBase
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public BookEntity Book { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
