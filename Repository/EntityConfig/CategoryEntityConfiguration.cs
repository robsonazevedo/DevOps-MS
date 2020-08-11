using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.EntityConfig
{
    public class CategoryEntityConfiguration : EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryEntityConfiguration()
        {
            // Caracteristicas da tabela no banco de dado
            HasKey(c => c.Id);

            Property(c => c.Name)                
                .IsRequired()
                .HasMaxLength(64);

            Property(c => c.Description)
                .IsRequired();

            // Nomemclaturas de Tabela colunas no banco de dados
            ToTable("Category");
        }
    }
}
