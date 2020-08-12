using Domain.Entities;
using Domain.Services;
using Repository.Repositories;

namespace App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            List();
        }

        private static void List()
        {
            using (var svsCategory = new CategoryService(new CategoryRepository()))
            {
                var categories = svsCategory.GetList(c => c.Id > 0);

                foreach (var c in categories)
                {
                    System.Console.WriteLine(c.Name);
                }

                System.Console.ReadKey();
            };
        }

        private static void Add()
        {
            System.Console.Write("Nome Categoria: ");
            var name = System.Console.ReadLine();

            System.Console.WriteLine();

            System.Console.Write("Descrição Categoria: ");
            var description = System.Console.ReadLine();

            var svsBook = new BookService(new BookRepository());
            var svsCategory = new CategoryService(new CategoryRepository());

            svsCategory.Add(new CategoryEntity
            {
                Name = name,
                Description = description
            });

            svsBook.Dispose();
            svsCategory.Dispose();
        }
    }
}
