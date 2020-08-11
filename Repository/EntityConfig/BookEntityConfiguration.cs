using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.EntityConfig
{
    public class BookEntityConfiguration : EntityTypeConfiguration<BookEntity>
    {
        public BookEntityConfiguration()
        {
            // Caracteristicas da tabela no banco de dados
            HasKey(b => b.Id);

            Property(b => b.Name)
               .IsRequired()
               .HasMaxLength(32);

            Property(b => b.Year)
               .IsRequired();

            // Nomemclaturas de Tabela colunas no banco de dados
            ToTable("Book");
            Property(b => b.Name).HasColumnName("Name");
            Property(b => b.PagesNumber).HasColumnName("PagesNumber");
            Property(b => b.Year).HasColumnName("ColYear");
        }
    }
}
