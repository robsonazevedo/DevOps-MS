using App.Console.Enumerators;
using App.Console.Executions;

namespace App.Console.Helper
{
    public static class ExecuteOptionHelper
    {
        public static void ExecuteBookOption(MenuBookOptions menuBookOption)
        {
            var executeBook = new ExecuteBook();

            System.Console.Clear();

            switch (menuBookOption)
            {
                case MenuBookOptions.Search:
                    {
                        executeBook.Search();
                        break;
                    }
                case MenuBookOptions.List:
                    {
                        executeBook.List();
                        break;
                    }
                case MenuBookOptions.Add:
                    {
                        executeBook.Add();
                        break;
                    }
                case MenuBookOptions.Update:
                    {
                        executeBook.Update();
                        break;
                    }
                case MenuBookOptions.Delete:
                    {
                        executeBook.Delete();
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

            System.Console.Clear();

            switch (menuCategoryOption)
            {
                case MenuCategoryOptions.Search:
                    {
                        executeCategory.Search();
                        break;
                    }
                case MenuCategoryOptions.List:
                    {
                        executeCategory.List();
                        break;
                    }
                case MenuCategoryOptions.Add:
                    {
                        executeCategory.Add();
                        break;
                    }
                case MenuCategoryOptions.Update:
                    {
                        executeCategory.Update();
                        break;
                    }
                case MenuCategoryOptions.Delete:
                    {
                        executeCategory.Delete();
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
