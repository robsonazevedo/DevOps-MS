using App.Console.Enumerators;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace App.Console.Helper
{
    internal static class ViewMenuHelper
    {
        public static MenuBookOptions ViewBookMenu()
        {
            System.Console.WriteLine(GetView("menu-book"));
            System.Console.SetCursorPosition(9, 12);

            var option = GetOption();
            return (MenuBookOptions)option;
        }

        public static MenuCategoryOptions ViewCategoryMenu()
        {
            System.Console.WriteLine(GetView("menu-category"));
            System.Console.SetCursorPosition(9, 12);

            var option = GetOption();
            return (MenuCategoryOptions)option;
        }

        public static MenuConsoleOptions ViewConsoleMenu()
        {
            System.Console.WriteLine(GetView("menu"));
            System.Console.SetCursorPosition(9, 10);

            var option = GetOption();
            return (MenuConsoleOptions)option;
        }

        public static void ViewError(string error)
        {
            System.Console.WriteLine(GetView("error"));
            System.Console.Write(error, error.IndexOf('_'), error.Count());
        }

        private static string GetView(string view)
        {
            using (var sr = new StreamReader($@"Templates\{view}.txt", Encoding.UTF8))
            {
                return sr.ReadToEnd();
            }
        }

        private static int GetOption()
        {
            var option = "";
            ConsoleKeyInfo key;

            do
            {
                key = System.Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    bool _x = double.TryParse(key.KeyChar.ToString(), out _);
                    if (_x && option.Length == 0)
                    {
                        option += key.KeyChar;
                        System.Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && option.Length > 0)
                    {
                        option = option.Substring(0, (option.Length - 1));
                        System.Console.Write("\b \b");
                    }
                }
            }

            while (key.Key != ConsoleKey.Enter);

            return Convert.ToInt32(string.IsNullOrEmpty(option) ? "0" : option);
        }
    }
}
