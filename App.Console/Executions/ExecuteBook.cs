using Application;
using Domain.Entities;
using Domain.Services;
using Repository.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace App.Console.Executions
{
    internal class ExecuteBook : IExecuteBase<BookEntity>
    {
        private readonly BookAppService BookAppService;

        public ExecuteBook() => BookAppService = new BookAppService(new BookService(new BookRepository()));

        public void Add(BookEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(BookEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void List()
        {
            System.Console.WriteLine("Consultando...");
            var books = BookAppService.GetList(c => c.Id > 0);
            ListBooks(books);
        }

        public void Search(string name)
        {
            System.Console.WriteLine("Consultando...");
            var books = BookAppService.GetList(c => c.Name.Contains(name));
            ListBooks(books);
        }


        public void Update(BookEntity entity)
        {
            throw new System.NotImplementedException();
        }

        private static void ListBooks(IEnumerable<BookEntity> books)
        {
            var isColumns = true;

            System.Console.Clear();

            if (!books.Any())
            {
                System.Console.WriteLine("Sem registros!!!");
            }
            else
            {
                foreach (var c in books)
                {
                    if (isColumns)
                    {
                        System.Console.Write(nameof(c.Id).PadRight(4));
                        System.Console.Write(nameof(c.Name).PadRight(16));
                        System.Console.Write(nameof(c.Year).PadRight(5));
                        System.Console.Write(nameof(c.PagesNumber).PadRight(5));
                        System.Console.Write(nameof(c.DateInsert).PadRight(20));
                        System.Console.Write(nameof(c.DateUpdate).PadRight(20));
                        System.Console.Write(nameof(c.IsTest).PadRight(12));
                        System.Console.Write(nameof(c.Categories));

                        isColumns = false;
                    }

                    System.Console.WriteLine();
                    System.Console.Write(c.Id.ToString("00").PadRight(4));
                    System.Console.Write(c.Name.PadRight(16));
                    System.Console.Write(c.Year.ToString("0000").PadRight(5));
                    System.Console.Write(c.PagesNumber.ToString("0000").PadRight(5));
                    System.Console.Write(c.DateInsert.ToString("dd/MM/yyyy hh:mm:ss").PadRight(20));
                    System.Console.Write(c.DateUpdate?.ToString("dd/MM/yyyy hh:mm:ss") ?? "".PadRight(20));
                    System.Console.Write(c.IsTest.ToString().PadRight(12));
                    System.Console.Write(c.Categories.Count.ToString("000"));
                }
            }

            System.Console.WriteLine("\n\nContinuar...");
            System.Console.ReadKey();
        }
    }
}
