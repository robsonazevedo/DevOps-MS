using Application;
using Domain.Services;
using Repository.Repositories;
using System.Linq;

namespace App.Console.Executions
{
    public class ExecuteCategory : IExecuteBase
    {
        private readonly CategoryAppService CategoryAppService;

        public ExecuteCategory() => CategoryAppService = new CategoryAppService(new CategoryService(new CategoryRepository()));

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

            var categories = CategoryAppService.GetList(c => c.Id > 0);
            var isColumns = true;

            System.Console.Clear();

            if (categories.Count() <= 0)
            {
                System.Console.WriteLine("Sem registros!!!");
            }
            else
            {
                foreach (var c in categories)
                {
                    if (isColumns)
                    {
                        System.Console.Write(nameof(c.Id).PadRight(4));
                        System.Console.Write(nameof(c.Name).PadRight(16));
                        System.Console.Write(nameof(c.Description).PadRight(32));
                        System.Console.Write(nameof(c.DateInsert).PadRight(20));
                        System.Console.Write(nameof(c.DateUpdate).PadRight(20));
                        System.Console.Write(nameof(c.IsTest).PadRight(12));
                        System.Console.Write(nameof(c.Books));

                        isColumns = false;
                    }

                    System.Console.WriteLine();
                    System.Console.Write(c.Id.ToString("00").PadRight(4));
                    System.Console.Write(c.Name.PadRight(16));
                    System.Console.Write(c.Description.PadRight(32));
                    System.Console.Write(c.DateInsert.ToString("dd/MM/yyyy hh:mm:ss").PadRight(20));
                    System.Console.Write(c.DateUpdate?.ToString("dd/MM/yyyy hh:mm:ss") ?? "".PadRight(20));
                    System.Console.Write(c.IsTest.ToString().PadRight(12));
                    System.Console.Write(c.Books.Count.ToString("000"));
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
