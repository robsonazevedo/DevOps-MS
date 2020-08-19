using System;

namespace App.Console.Helper
{
    internal static class SystemHelper
    {
        public static int GetOption()
        {
            var option = "";
            ConsoleKeyInfo key;

            do
            {
                key = System.Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    var _x = double.TryParse(key.KeyChar.ToString(), out _);
                    if (_x && option.Length < 1)
                    {
                        option = string.Concat(option, key.KeyChar);
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

        internal static string GetInput()
        {
            var input = "";
            ConsoleKeyInfo key;

            do
            {
                key = System.Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if (input.Length < 40 && key.Key != ConsoleKey.Enter)
                    {
                        input = string.Concat(input, key.KeyChar);
                        System.Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input.Substring(0, (input.Length - 1));
                        System.Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);

            System.Console.WriteLine();

            return input;
        }
    }
}
