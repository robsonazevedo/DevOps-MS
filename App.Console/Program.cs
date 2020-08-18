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
                var menuConsoleOption = ViewMenuHelper.ViewConsoleMenu();

                while (isContinue)
                {

                    switch (menuConsoleOption)
                    {
                        case MenuConsoleOptions.Book:
                            {
                                var menuBookOption = ViewMenuHelper.ViewBookMenu();
                                ExecuteOptionHelper.ExecuteBookOption(menuBookOption);
                                break;
                            }
                        case MenuConsoleOptions.Category:
                            {
                                var menuCategoryOption = ViewMenuHelper.ViewCategoryMenu();
                                ExecuteOptionHelper.ExecuteCategoryOption(menuCategoryOption);
                                break;
                            }
                        default:
                            {
                                isContinue = true;
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Clear();
                ViewMenuHelper.ViewError(ex.ToString());
            }
        }
    }
}
