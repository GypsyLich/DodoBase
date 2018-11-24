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

        public static ClothesTypes ItemChoise()
        {
            while (true)
            {
                var itemInput = Console.ReadLine();
                if (itemInput == "1" || itemInput == "2" || itemInput == "3")
                {
                    return (ClothesTypes)Enum.Parse(typeof(ClothesTypes), itemInput);
                }
                Misc.ConsoleLog(ConsoleColor.Yellow, "Please, choose \"Tops\", \"Pants\" or \"Shoes\"");
            }
        }

        public static int ActionChoice(ClothesTypes ClothesType)
        {
            Misc.ConsoleLog(ConsoleColor.Yellow, $"1-remove {ClothesType} (by ID)\n2-add default {ClothesType}" +
            $" \n3-add {ClothesType} with parameters \n4-search info about the {ClothesType} in DataBase" +
            $"\n5-show all {ClothesType} DataBase \n6-update {ClothesType} by ID");
            while (true)
            {
                var result = Int32.TryParse(Console.ReadLine(), out int choice);
                if (result && choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    return choice;
                }
                Misc.ConsoleLog(ConsoleColor.Yellow, "Choose 1, 2, 3 or 4");
            }
        }
    }
}
