using E_shirt.DataTypes;

namespace E_shirt.Managers
{
    class AppFuncs
    {
        public static void Listener(ClothesContext db)
        {
            while (true)
            {
                var itemChoise = Misc.ItemChoise();
                var actionChoice = Misc.ActionChoice(itemChoise);
            }
        }

        public static void AddDefault()
        {

        }

        public static void AddItem()
        {

        }

        public static void ShowItemById()
        {

        }

        public static void ShowDB(ClothesContext db, ClothesTypes itemChoise)
        {
            switch (itemChoise)
            {
                case  :
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public static void UpdateItemById()
        {

        }

    }
}
