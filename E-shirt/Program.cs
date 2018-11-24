using E_shirt.Managers;
using System;

namespace E_shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothesContext db = new ClothesContext();
            try
            {
                AppFuncs.Listener(db);
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
