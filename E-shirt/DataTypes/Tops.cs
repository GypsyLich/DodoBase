namespace E_shirt.DataTypes
{
    public class Tops : Clothes
    {
        public string Brand { get; set; }
        public bool WaterProof { get; set; }

        public Tops() : this("def. brand", false, 0, 0, "white") { }
        public Tops(string brand, bool waterProof, int size, int price, string color)
            : base(size, price, color)
        {
            Brand = brand;
            WaterProof = waterProof;
        }
    }
}
