using Application;
using Domain.Services;
using Repository.Repositories;
using System.Linq;

namespace App.Console.Executions
{
    public class ExecuteBook : IExecuteBase
    {
        private readonly BookAppService BookAppService;

        public ExecuteBook() => BookAppService = new BookAppService(new BookService(new BookRepository()));

        public void Add()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void List()
        {
            System.Console.WriteLine("Consultando...");

            var books = BookAppService.GetList(c => c.Id > 0);
            var isColumns = true;

            System.Console.Clear();

            if (books.Count() <= 0)
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
        }

        public void Search()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
