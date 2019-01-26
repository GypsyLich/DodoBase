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
                            db.Tops.Add(new Tops(Misc.GetParameter("Brand"),
                               Boolean.Parse(Misc.GetParameter("WaterProof")), Int32.Parse(Misc.GetParameter("Size")), Int32.Parse(Misc.GetParameter("Price")),
                               Int32.Parse(Misc.GetParameter("Color"))));
                            break;
                        case ClothesTypes.Pants:
                            db.Pants.Add(new Pants(Misc.GetParameter("Model"), Misc.GetParameter("Type"), Int32.Parse(Misc.GetParameter("Size")), Int32.Parse(Misc.GetParameter("Price")),
                              Int32.Parse(Misc.GetParameter("Color"))));
                            break;
                        case ClothesTypes.Shoes:
                            db.Shoes.Add(new Shoes(Misc.GetParameter("Heels"), Misc.GetParameter("Season"), Int32.Parse(Misc.GetParameter("Size")), Int32.Parse(Misc.GetParameter("Price")),
                                Int32.Parse(Misc.GetParameter("Color"))));
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
