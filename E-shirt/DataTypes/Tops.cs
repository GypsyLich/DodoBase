namespace E_shirt.DataTypes
{
    class Tops : Clothes
    {
        public string Brand { get; set; }
        public bool WaterProof { get; set; }

        public Tops() : this("def. brand", false, 0, 0, 0) { }
        public Tops(string brand, bool waterProof, int size, int price, int color)
            : base(size, price, color)
        {
            Brand = brand;
            WaterProof = waterProof;
        }
    }
}
