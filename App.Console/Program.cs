using Domain.Entities;
using Domain.Services;
using Repository.Repositories;
using System.Linq;

namespace App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCategory();
            List();
            AddBook();

            System.Console.ReadKey();
        }

        private static void AddBook()
        {
            var book = new BookEntity();
            
            book.Name = "It a coisa";
            book.Year = 2020;
            book.PagesNumber = 1000;
            book.BookCategory = new BookCategoryEntity
            {
                CategoryId = 1,
                BookId = book.Id
            };




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

            };
        }

        private static void AddCategory()
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
