using App.Console.Enumerators;
using App.Console.Executions;
using App.Console.View;

namespace App.Console
{
    internal static class ExecuteOption
    {
        public static void ExecuteBookOption(MenuBookOptions menuBookOption)
        {
            var executeBook = new ExecuteBook();
            var viewBook = new ViewBookMenu();
            System.Console.Clear();

            switch (menuBookOption)
            {
                case MenuBookOptions.Search:
                    {
                        var name = viewBook.ViewSearch();
                        executeBook.Search(name);
                        break;
                    }
                case MenuBookOptions.List:
                    {
                        executeBook.List();
                        break;
                    }
                case MenuBookOptions.Add:
                    {
                        var book = viewBook.ViewAdd();
                        executeBook.Add(book);
                        break;
                    }
                case MenuBookOptions.Update:
                    {
                        var book = viewBook.ViewUpdate();
                        executeBook.Update(book);
                        break;
                    }
                case MenuBookOptions.Delete:
                    {
                        var book = viewBook.ViewDelete();
                        executeBook.Delete(book);
                        break;
                    }
                case MenuBookOptions.Exit:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public static void ExecuteCategoryOption(MenuCategoryOptions menuCategoryOption)
        {
            var executeCategory = new ExecuteCategory();
            var viewCategory = new ViewCategoryMenu();
            System.Console.Clear();

            switch (menuCategoryOption)
            {
                case MenuCategoryOptions.Search:
                    {
                        var name = viewCategory.ViewSearch();
                        executeCategory.Search(name);
                        break;
                    }
                case MenuCategoryOptions.List:
                    {
                        executeCategory.List();
                        break;
                    }
                case MenuCategoryOptions.Add:
                    {
                        var category = viewCategory.ViewAdd();
                        executeCategory.Add(category);
                        break;
                    }
                case MenuCategoryOptions.Update:
                    {
                        var category = viewCategory.ViewUpdate();
                        executeCategory.Update(category);
                        break;
                    }
                case MenuCategoryOptions.Delete:
                    {
                        var category = viewCategory.ViewDelete();
                        executeCategory.Delete(category);
                        break;
                    }
                case MenuCategoryOptions.Exit:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
