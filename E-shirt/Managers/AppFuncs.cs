using E_shirt.DataTypes;
using System;

namespace E_shirt.Managers
{
    public class AppFuncs
    {
        public static ClothesContext db = new ClothesContext();

        public static void Listener()
        {
            while (true)
            {
                var itemChoise = Misc.ItemChoise();
                ShowDB(itemChoise);
                var actionChoice = Misc.ActionChoice(itemChoise);
                int id;
                switch (actionChoice)
                {
                    case 1:
                        id = Misc.GetId(itemChoise, db);
                        RemoveItembyId(itemChoise, id);
                        break;
                    case 2:
                        AddDefault(itemChoise);
                        break;
                    case 3:
                        AddItem(itemChoise);
                        break;
                    case 4:
                        id = Misc.GetId(itemChoise, db);
                        ShowItemById(itemChoise, id);
                        break;
                    case 5:
                        id = Misc.GetId(itemChoise, db);
                        UpdateItemById(itemChoise, id);
                        break;
                }
                db.SaveChanges();
                Misc.ConsoleLog(ConsoleColor.Yellow, "Changes have been saved, exit (Y/N)?");
                string temp = Console.ReadLine();
                if (temp == "Y" || temp == "y")
                {
                    break;
                }
            }
        }

        public static void RemoveItembyId(ClothesTypes itemChoise, int id)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = Misc.SelectTopsById(itemChoise, id);
                            db.Tops.Remove(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = Misc.SelectPantsById(itemChoise, id);
                            db.Pants.Remove(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = Misc.SelectShoesById(itemChoise, id);
                            db.Shoes.Remove(shoesItem);
                            break;
                    }
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public static void AddDefault(ClothesTypes itemChoise)
        {
            switch (itemChoise)
            {
                case ClothesTypes.Tops:
                    db.Tops.Add(new Tops());
                    break;
                case ClothesTypes.Pants:
                    db.Pants.Add(new Pants());
                    break;
                case ClothesTypes.Shoes:
                    db.Shoes.Add(new Shoes());
                    break;
            }
        }

        public static void AddItem(ClothesTypes itemChoise)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = db.Tops.Add(new Tops());
                            Misc.ChangeProperty(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = db.Pants.Add(new Pants());
                            Misc.ChangeProperty(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = db.Shoes.Add(new Shoes());
                            Misc.ChangeProperty(shoesItem);
                            break;
                    }
                    break;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void ShowItemById(ClothesTypes itemChoise, int id)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = Misc.SelectTopsById(itemChoise, id);
                            Misc.ShowItem(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = Misc.SelectPantsById(itemChoise, id);
                            Misc.ShowItem(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = Misc.SelectShoesById(itemChoise, id);
                            Misc.ShowItem(shoesItem);
                            break;
                    }
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public static void ShowDB(ClothesTypes itemChoise)
        {
            switch (itemChoise)
            {
                case ClothesTypes.Tops:
                    foreach (var item in db.Tops)
                    {
                        Misc.ShowItem(item);
                    }
                    break;
                case ClothesTypes.Pants:
                    foreach (var item in db.Pants)
                    {
                        Misc.ShowItem(item);
                    }
                    break;
                case ClothesTypes.Shoes:
                    foreach (var item in db.Shoes)
                    {
                        Misc.ShowItem(item);
                    }
                    break;
            }
        }

        public static void UpdateItemById(ClothesTypes itemChoise, int id)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = Misc.SelectTopsById(itemChoise, id);
                            Misc.ShowItem(topsItem);
                            Misc.ChangeProperty(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = Misc.SelectPantsById(itemChoise, id);
                            Misc.ShowItem(pantsItem);
                            Misc.ChangeProperty(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = Misc.SelectShoesById(itemChoise, id);
                            Misc.ShowItem(shoesItem);
                            Misc.ChangeProperty(shoesItem);
                            break;
                    }
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

    }
}
