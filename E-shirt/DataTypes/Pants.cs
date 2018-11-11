using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shirt.DataTypes
{
    class Pants : Clothes
    {
        public string Model { get; set; }
        public string Type { get; set; }

        public Pants() : this("def. model", "def. type", 0, 0, 0, 0) { }
        public Pants(string model, string type, int size, int price, int color, int id)
            : base(size, price, color, id)
        {
            Model = model;
            Type = type;
        }
    }
}
