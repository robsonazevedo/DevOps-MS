using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.EntityConfig
{
    public class BookEntityConfiguration : EntityTypeConfiguration<BookEntity>
    {
        public BookEntityConfiguration()
        {
            HasKey(b => b.Id);

            Property(b => b.Name)
               .IsRequired()
               .HasMaxLength(32);

            Property(b => b.Year)
               .IsRequired();

            ToTable("Book");
            Property(c => c.Id).HasColumnName("BookId");
        }
    }
}
