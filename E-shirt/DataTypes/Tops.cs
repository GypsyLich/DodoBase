namespace E_shirt.DataTypes
{
    class Tops : Clothes
    {
        public string Heels { get; set; }
        public string Season { get; set; }

        public Tops() : this("def. heels", "def. season", 0, 0, 0) { }
        public Tops(string heels, string season, int size, int price, int color)
            : base(size, price, color)
        {
            Heels = heels;
            Season = season;
        }
    }
}
