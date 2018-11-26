using E_shirt.DataTypes;

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
                var id = actionChoice == 1 || actionChoice == 4 || actionChoice == 6 ? Misc.GetId(itemChoise , db) : -1;
                switch (actionChoice)
                {
                    case 1:
                        RemoveItembyId(itemChoise, id);
                        break;
                    case 2:
                        AddDefault(itemChoise);
                        break;
                    case 3:
                        AddItem(itemChoise);
                        break;
                    case 4:
                        ShowItemById(itemChoise, id);
                        break;
                    case 5:
                        ShowDB(itemChoise);
                        break;
                    case 6:
                        UpdateItemById(itemChoise, id);
                        break;
                }
                db.SaveChanges();
            }
        }

        public static void RemoveItembyId(ClothesTypes itemChoise, int id)
        {

        }

        public static void AddDefault(ClothesTypes itemChoise)
        {

        }

        public static void AddItem(ClothesTypes itemChoise)
        {

        }

        public static void ShowItemById(ClothesTypes itemChoise, int id)
        {

        }

        public static void ShowDB(ClothesTypes itemChoise)
        {
            switch (itemChoise.ToString())
            {
                case "Tops":
                    break;
                case "Pants":
                    break;
                case "Shoes":
                    break;
            }
        }

        public static void UpdateItemById(ClothesTypes itemChoise, int id)
        {

        }

    }
}
