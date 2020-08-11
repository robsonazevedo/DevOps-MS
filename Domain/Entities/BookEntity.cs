namespace Domain.Entities
{
    public class BookEntity : EntityBase
    {
        public string Name { get; set; }
        public int PagesNumber { get; set; }
        public int Year { get; set; }
    }
}
