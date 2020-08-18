using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.EntityConfig
{
    public class CategoryEntityConfiguration : EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryEntityConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(64);

            Property(c => c.Description)
                .IsRequired();

            ToTable("Category");
            Property(c => c.Id).HasColumnName("CategoryId");
        }
    }
}
