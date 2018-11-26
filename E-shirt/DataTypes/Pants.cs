namespace E_shirt.DataTypes
{
    class Pants : Clothes
    {
        public string Model { get; set; }
        public string Type { get; set; }

        public Pants() : this("def. model", "def. type", 0, 0, 0) { }
        public Pants(string model, string type, int size, int price, int color)
            : base(size, price, color)
        {
            Model = model;
            Type = type;
        }
    }
}
