using App.Console.Helper;
using Domain.Entities;
using Domain.Interfaces.AppServices;
using Domain.Services;
using System.Collections.Generic;
using System.Linq;

namespace App.Console.Executions
{
    internal class ExecuteCategory : IExecuteBase<CategoryEntity>
    {
        private readonly ICategoryAppService CategoryAppService;

        public ExecuteCategory() => CategoryAppService = SystemHelper.Container.GetInstance<ICategoryAppService>();

        public void Add(CategoryEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(CategoryEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void List()
        {
            System.Console.WriteLine("Consultando...");
            var categories = CategoryAppService.GetList(c => c.Id > 0);
            ListCategories(categories);
        }

        public void Search(string name)
        {
            System.Console.WriteLine("Consultando...");
            var categories = CategoryAppService.GetList(c => c.Name.Contains(name));
            ListCategories(categories);
        }

        public void Update(CategoryEntity entity)
        {
            throw new System.NotImplementedException();
        }

        private static void ListCategories(IEnumerable<CategoryEntity> categories)
        {
            System.Console.Clear();

            if (!categories.Any())
            {
                System.Console.WriteLine("Sem registros!!!");
            }
            else
            {

                var isColumns = true;

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

            System.Console.WriteLine("\n\nContinuar...");
            System.Console.ReadKey();
        }
    }
}
