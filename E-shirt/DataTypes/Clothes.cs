namespace E_shirt.DataTypes
{
    class Clothes
    {
        public int Size { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public int Id { get; set; }
        public Clothes(int size, int price, string color)
        {
            Size = size;
            Price = price;
            Color = color;
        }
        public Clothes() : this(0, 0, "white") { }
    }
}
