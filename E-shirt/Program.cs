using E_shirt.Managers;
using System;

namespace E_shirt
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppFuncs.Listener();
            }
            catch (Exception exception)
            {
                Misc.ConsoleLog(ConsoleColor.Green, exception.ToString());
                Misc.WriteDataToFile(@"..\..\Log.txt", exception.ToString());
            }
            finally
            {
                Console.Write("Press any key to quit: ");
                Console.ReadKey();
            }
        }
    }
}
