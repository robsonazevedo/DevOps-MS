using Domain.Entities;
using Repository.Context;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryContext context)
        {
            var category = new CategoryEntity
            {
                Name = "Comédia",
                Description = "Livros de comédia"
            };

            var categoryExists = context.Categories.Where(c => c.Name == category.Name);

            if (categoryExists is null)
                context.Categories.Add(category);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
