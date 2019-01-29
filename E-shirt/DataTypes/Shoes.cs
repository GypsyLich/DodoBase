namespace E_shirt.DataTypes
{
    class Shoes : Clothes
    {
        public string Heels { get; set; }
        public string Season { get; set; }

        public Shoes() : this("def. heels", "def. season", 0, 0, "white") { }
        public Shoes(string heels, string season, int size, int price, string color)
            : base(size, price, color)
        {
            Heels = heels;
            Season = season;
        }
    }
}
