using App.Console.Enumerators;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace App.Console.Helper
{
    internal static class ViewMenuHelper
    {
        public static string GetView(string view)
        {
            using (var sr = new StreamReader($@"Templates\{view}.txt", Encoding.UTF8))
            {
                return sr.ReadToEnd();
            }
        }

        public static MenuBookOptions ViewBookMenu()
        {
            System.Console.WriteLine(GetView("menu-book"));
            System.Console.SetCursorPosition(9, 13);

            var option = SystemHelper.GetOption();
            return (MenuBookOptions)option;
        }

        public static MenuCategoryOptions ViewCategoryMenu()
        {
            System.Console.WriteLine(GetView("menu-category"));
            System.Console.SetCursorPosition(9, 13);

            var option = SystemHelper.GetOption();
            return (MenuCategoryOptions)option;
        }

        public static MenuConsoleOptions ViewConsoleMenu()
        {
            System.Console.WriteLine(GetView("menu"));
            System.Console.SetCursorPosition(9, 10);

            var option = SystemHelper.GetOption();
            return (MenuConsoleOptions)option;
        }

        public static void ViewError(string err)
        {
            System.Console.WriteLine(GetView("error"));
            System.Console.Write(err, err.IndexOf('_'), err.Count());
        }
    }
}
