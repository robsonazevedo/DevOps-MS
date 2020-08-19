using App.Console.Enumerators;
using App.Console.Helper;
using IoC;
using System;

namespace App.Console
{
    public class Program
    {
        protected Program()
        {
        }

        public static void Main(string[] args)
        {
            try
            {
                var isContinue = true;

                while (isContinue)
                {
                    var menuConsoleOption = ViewMenuHelper.ViewConsoleMenu();
                    System.Console.Clear();

                    switch (menuConsoleOption)
                    {
                        case MenuConsoleOptions.Book:
                            {
                                var menuBookOption = ViewMenuHelper.ViewBookMenu();
                                ExecuteOption.ExecuteBookOption(menuBookOption);
                                break;
                            }
                        case MenuConsoleOptions.Category:
                            {
                                var menuCategoryOption = ViewMenuHelper.ViewCategoryMenu();
                                ExecuteOption.ExecuteCategoryOption(menuCategoryOption);
                                break;
                            }
                        case MenuConsoleOptions.Exit:
                            {
                                isContinue = false;
                                break;
                            }
                        default:
                            {
                                System.Console.Clear();
                                isContinue = true;
                                break;
                            }
                    }

                    System.Console.Clear();
                }
            }
            catch (Exception ex)
            {
                System.Console.Clear();
                ViewMenuHelper.ViewError(ex.ToString());
                System.Console.ReadKey();
            }
        }
    }
}
