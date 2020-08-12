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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LibraryContext context)
        {
            var categoryRomance = new CategoryEntity
            {
                Name = "Romance",
                Description = "Livros de Romance"
            };

            var categoryMagia = new CategoryEntity
            {
                Name = "Magia",
                Description = "Livros de Magia"
            };

            var categoryFiccao = new CategoryEntity
            {
                Name = "Ficção",
                Description = "Livros de Ficção"
            };

            var categoryRomanceExists = context.Categories.Where(c => c.Name == categoryRomance.Name);
            var categoryMagiaExists = context.Categories.Where(c => c.Name == categoryMagia.Name);
            var categoryFiccaoExists = context.Categories.Where(c => c.Name == categoryFiccao.Name);

            if (categoryRomanceExists.Count() <= 0)
                context.Categories.Add(categoryRomance);

            if (categoryMagiaExists.Count() <= 0)
                context.Categories.Add(categoryMagia);

            if (categoryFiccaoExists.Count() <= 0)
                context.Categories.Add(categoryFiccao);
        }
    }
}
