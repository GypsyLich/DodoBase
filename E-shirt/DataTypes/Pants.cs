namespace E_shirt.DataTypes
{
    public class Pants : Clothes
    {
        public string Model { get; set; }
        public string Type { get; set; }

        public Pants() : this("def. model", "def. type", 0, 0, "white") { }
        public Pants(string model, string type, int size, int price, string color)
            : base(size, price, color)
        {
            Model = model;
            Type = type;
        }
    }
}
