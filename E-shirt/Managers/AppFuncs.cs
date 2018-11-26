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
                        ShowDB(itemChoise);
                        break;
                    case 6:
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
                            db.Tops.Add(new Tops(Convert.ToInt32(Misc.GetParameter("Size")), Convert.ToInt32(Misc.GetParameter("Price")),
                               Convert.ToInt32(Misc.GetParameter("Color")), Misc.GetParameter("Heels"), Misc.GetParameter("Season")));
                            break;
                        case ClothesTypes.Pants:
                            db.Pants.Add(new Pants(Convert.ToInt32(Misc.GetParameter("Size")), Convert.ToInt32(Misc.GetParameter("Price")),
                               Convert.ToInt32(Misc.GetParameter("Color")), Misc.GetParameter("Model"), Misc.GetParameter("Type")));
                            break;
                        case ClothesTypes.Shoes:
                            db.Shoes.Add(new Shoes(Convert.ToInt32(Misc.GetParameter("Size")), Convert.ToInt32(Misc.GetParameter("Price")),
                               Convert.ToInt32(Misc.GetParameter("Color")), Misc.GetParameter("Brand"),
                               Convert.ToBoolean(Misc.GetParameter("WaterProof"))));
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void ShowItemById(ClothesTypes itemChoise)
        {

        }

        public static void ShowDB(ClothesTypes itemChoise)
        {
            switch (itemChoise)
            {
                case ClothesTypes.Tops:
                    break;
                case ClothesTypes.Pants:
                    break;
                case ClothesTypes.Shoes:
                    break;
            }
        }

        public static void UpdateItemById(ClothesTypes itemChoise)
        {

        }

    }
}
