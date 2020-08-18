using App.Console.Enumerators;
using App.Console.Helper;
using System;

namespace App.Console
{
    public class Program
    {
        static void Main(string[] args)
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
                                ExecuteOptionHelper.ExecuteBookOption(menuBookOption);
                                System.Console.WriteLine("\n\nContinuar...");
                                System.Console.ReadKey();
                                break;
                            }
                        case MenuConsoleOptions.Category:
                            {
                                var menuCategoryOption = ViewMenuHelper.ViewCategoryMenu();
                                ExecuteOptionHelper.ExecuteCategoryOption(menuCategoryOption);
                                System.Console.WriteLine("\n\nContinuar...");
                                System.Console.ReadKey();
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
