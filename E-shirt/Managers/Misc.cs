using E_shirt.DataTypes;
using System;
using System.IO;

namespace E_shirt.Managers
{
    public class Misc
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

        public static int GetId(ClothesTypes itemChoise, ClothesContext db)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter item's Id: ");
                    var id = Convert.ToInt32(Console.ReadLine());
                    if ((db.Tops.Find(id) == null && itemChoise == ClothesTypes.Tops) || (db.Pants.Find(id) == null && itemChoise == ClothesTypes.Pants) || (db.Shoes.Find(id) == null && itemChoise == ClothesTypes.Shoes))
                    {
                        Misc.ConsoleLog(ConsoleColor.Yellow, $"Sorry, there is no {itemChoise} in DataBase with such ID, exit (Y/N)?");
                        string temp = Console.ReadLine();
                        if ( temp == "Y" || temp == "y")
                        {
                            return -1;
                        }
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
                Misc.ConsoleLog(ConsoleColor.Yellow, "Choose \"Tops\", \"Pants\" or \"Shoes\"");
                var itemInput = Console.ReadLine();
                if (itemInput == "Tops" || itemInput == "Pants" || itemInput == "Shoes")
                {
                    return (ClothesTypes)Enum.Parse(typeof(ClothesTypes), itemInput);
                }
                Misc.ConsoleLog(ConsoleColor.Yellow, "Please, choose \"Tops\", \"Pants\" or \"Shoes\"");
            }
        }

        public static int ActionChoice(ClothesTypes ClothesType)
        {
            Misc.ConsoleLog(ConsoleColor.Yellow, $"1-remove {ClothesType} (by ID)\n2-add default {ClothesType}" +
            $" \n3-add {ClothesType} with parameters \n4-search info about the {ClothesType} by ID" +
            $"\n5-update {ClothesType} by ID");
            while (true)
            {
                var result = Int32.TryParse(Console.ReadLine(), out int choice);
                if (result && choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
                {
                    return choice;
                }
                Misc.ConsoleLog(ConsoleColor.Yellow, "Choose 1, 2, 3, 4 or 5");
            }
        }

        public static string GetParameter(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }

        public static void ShowItem(Tops topsItem)
        {
            Misc.ConsoleLog(ConsoleColor.Cyan, $"Brand: {topsItem.Brand}\nWaterProof: {topsItem.WaterProof}\nSize: {topsItem.Size}\nPrice: {topsItem.Price}\nColor: {topsItem.Color}\nid: {topsItem.Id}\n");
        }

        public static void ShowItem(Pants pantsItem)
        {
            Misc.ConsoleLog(ConsoleColor.Red, $"Model: {pantsItem.Model}\nType: {pantsItem.Type}\nSize: {pantsItem.Size}\nPrice: {pantsItem.Price}\nColor: {pantsItem.Color}\nid: {pantsItem.Id}\n");
        }

        public static void ShowItem(Shoes shoesItem)
        {
            Misc.ConsoleLog(ConsoleColor.Magenta, $"Heels: {shoesItem.Heels}\nSeason: {shoesItem.Season}\nSize: {shoesItem.Size}\nPrice: {shoesItem.Price}\nColor: {shoesItem.Color}\nid: {shoesItem.Id}\n");
        }

        public static void ChangeProperty(Tops topsItem)
        {
            while (true)
            {
                try
                {
                    topsItem.Brand = Misc.GetParameter("Brand");
                    topsItem.WaterProof = Boolean.Parse(Misc.GetParameter("WaterProof"));
                    topsItem.Size = Int32.Parse(Misc.GetParameter("Size"));
                    topsItem.Price = Int32.Parse(Misc.GetParameter("Price"));
                    topsItem.Color = Misc.GetParameter("Color");
                    break;
                }
                catch (Exception)
                {
                    Misc.ConsoleLog(ConsoleColor.Yellow, "Incorrect input, try again");
                }
            }
        }
        public static void ChangeProperty(Pants pantsItem)
        {
            while (true)
            {
                try
                {
                    pantsItem.Model = Misc.GetParameter("Model");
                    pantsItem.Type = Misc.GetParameter("Type");
                    pantsItem.Size = Int32.Parse(Misc.GetParameter("Size"));
                    pantsItem.Price = Int32.Parse(Misc.GetParameter("Price"));
                    pantsItem.Color = Misc.GetParameter("Color");
                    break;
                }
                catch (Exception)
                {
                    Misc.ConsoleLog(ConsoleColor.Yellow, "Incorrect input, try again");
                }
            }
        }
        public static void ChangeProperty(Shoes shoesItem)
        {
            while (true)
            {
                try
                {
                    shoesItem.Heels = Misc.GetParameter("Heels");
                    shoesItem.Season = Misc.GetParameter("Season");
                    shoesItem.Size = Int32.Parse(Misc.GetParameter("Size"));
                    shoesItem.Price = Int32.Parse(Misc.GetParameter("Price"));
                    shoesItem.Color = Misc.GetParameter("Color");
                    break;
                }
                catch (Exception)
                {
                    Misc.ConsoleLog(ConsoleColor.Yellow, "Incorrect input, try again");
                }
            }
        }

        public static Tops SelectTopsById(ClothesTypes itemChoise, int id)
        {
            var topsItem = AppFuncs.db.Tops.Find(id);
            return topsItem;
        }

        public static Pants SelectPantsById(ClothesTypes itemChoise, int id)
        {
            var pantsItem = AppFuncs.db.Pants.Find(id);
            return pantsItem;
        }

        public static Shoes SelectShoesById(ClothesTypes itemChoise, int id)
        {
            var shoesItem = AppFuncs.db.Shoes.Find(id);
            return shoesItem;
        }
    }
}
