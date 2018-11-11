using System;
using System.IO;

namespace E_shirt.Managers
{
    class Misc
    {
        public static void ConsoleLog(ConsoleColor clr, string message)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine($"{message} \n");
            Console.ResetColor();
        }
        public static void WriteDataToFile(string filepath, string message)
        {
            File.AppendAllText(filepath, message);
        }

        public static void GetId()
        {

        }

    }
}
