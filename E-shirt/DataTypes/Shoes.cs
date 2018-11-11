namespace E_shirt.DataTypes
{
    class Shoes : Clothes
    {
        public string Brand { get; set; }
        public bool WaterProof { get; set; }

        public Shoes() : this("def. brand", false, 0, 0, 0, 0) { }
        public Shoes(string brand, bool waterProof, int size, int price, int color, int id)
            : base(size, price, color, id)
        {
            Brand = brand;
            WaterProof = waterProof;
        }
    }
}
