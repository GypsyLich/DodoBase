namespace E_shirt.DataTypes
{
    class Shoes : Clothes
    {
        public string Heels { get; set; }
        public string Season { get; set; }

        public Shoes() : this("def. heels", "def. season", 0, 0, 0) { }
        public Shoes(string heels, string season, int size, int price, int color)
            : base(size, price, color)
        {
            Heels = heels;
            Season = season;
        }
    }
}
