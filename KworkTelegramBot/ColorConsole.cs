using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    public class ColorConsole
    {
        public static void WriteLineColor(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor; // устанавливаем цвет
            Console.WriteLine(text);
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void WriteColor(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor; // устанавливаем цвет
            Console.Write(text);
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
