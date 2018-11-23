using E_shirt.DataTypes;
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

        public static int GetId(ClothesTypes transportType, ClothesContext db)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter item's Id: ");
                    var id = Convert.ToInt32(Console.ReadLine());
                    if ((db.Tops.Find(id) == null && transportType == ClothesTypes.Tops) || (db.Pants.Find(id) == null && transportType == ClothesTypes.Pants) || (db.Shoes.Find(id) == null && transportType == ClothesTypes.Shoes))
                    {
                        Misc.ConsoleLog(ConsoleColor.Yellow, $"Sorry, there is no {transportType} in DataBase.");

                    }
                    else
                    {
                        return id;
                    }
                }
                catch (Exception)
                {
                    Misc.ConsoleLog(ConsoleColor.Yellow, "Incorrect Id, try again");
                }
            }
        }

        public static ClothesContext Choise()
        {
            while (true)
            {
                var itemInput = Console.ReadLine();
                if (itemInput == "1" || itemInput == "2" || itemInput == "3")
                {
                    return (ClothesContext)Enum.Parse(typeof(ClothesContext), itemInput);
                }
                Misc.ConsoleLog(ConsoleColor.Yellow, "Please, choose \"Tops\", \"Pants\" or \"Shoes\"");
            }
        }
    }
}
