using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.EntityConfig
{
    public class BookCategoryConfiguration : EntityTypeConfiguration<BookCategoryEntity>
    {
        public BookCategoryConfiguration()
        {
            ToTable("BookCategory");
        }
    }
}
