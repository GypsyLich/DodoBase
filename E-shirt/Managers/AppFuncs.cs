using E_shirt.DataTypes;
using System;

namespace E_shirt.Managers
{
    class AppFuncs
    {
        public static ClothesContext db = new ClothesContext();

        public static void Listener()
        {
            while (true)
            {
                var itemChoise = Misc.ItemChoise();
                ShowDB(itemChoise);
                var actionChoice = Misc.ActionChoice(itemChoise);
                switch (actionChoice)
                {
                    case 1:
                        RemoveItembyId(itemChoise);
                        break;
                    case 2:
                        AddDefault(itemChoise);
                        break;
                    case 3:
                        AddItem(itemChoise);
                        break;
                    case 4:
                        ShowItemById(itemChoise);
                        break;
                    case 5:
                        UpdateItemById(itemChoise);
                        break;
                }
                db.SaveChanges();
            }
        }

        public static void RemoveItembyId(ClothesTypes itemChoise)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsForDeletion = db.Tops.Find(Misc.GetId(itemChoise, db));
                            db.Tops.Remove(topsForDeletion);
                            break;
                        case ClothesTypes.Pants:
                            var pantsForDeletion = db.Pants.Find(Misc.GetId(itemChoise, db));
                            db.Pants.Remove(pantsForDeletion);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesForDeletion = db.Shoes.Find(Misc.GetId(itemChoise, db));
                            db.Shoes.Remove(shoesForDeletion);
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

        public static void ShowItemById(ClothesTypes itemChoise)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = db.Tops.Find(Misc.GetId(itemChoise, db));
                            Misc.ShowItem(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = db.Pants.Find(Misc.GetId(itemChoise, db));
                            Misc.ShowItem(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = db.Shoes.Find(Misc.GetId(itemChoise, db));
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

        public static void UpdateItemById(ClothesTypes itemChoise)
        {
            while (true)
            {
                try
                {
                    switch (itemChoise)
                    {
                        case ClothesTypes.Tops:
                            var topsItem = db.Tops.Find(Misc.GetId(itemChoise, db));
                            Misc.ShowItem(topsItem);
                            Misc.ChangeProperty(topsItem);
                            break;
                        case ClothesTypes.Pants:
                            var pantsItem = db.Pants.Find(Misc.GetId(itemChoise, db));
                            Misc.ShowItem(pantsItem);
                            Misc.ChangeProperty(pantsItem);
                            break;
                        case ClothesTypes.Shoes:
                            var shoesItem = db.Shoes.Find(Misc.GetId(itemChoise, db));
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
