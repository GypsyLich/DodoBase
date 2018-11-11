using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shirt.DataTypes
{
    class Clothes
    {
        public int Size { get; set; }
        public int Price { get; set; }
        public int Color { get; set; }
        public int Id { get; set; }
        public Clothes(int size, int price, int color, int id)
        {
            Size = size;
            Price = price;
            Color = color;
            Id = id;
        }
        public Clothes() : this(0, 0, 0, 0) { }
    }
}
