using E_shirt.DataTypes;
using System.Data.Entity;

namespace E_shirt
{
    class ClothesContext : DbContext
    {
        public ClothesContext()
    : base("DbConnection")
        { }

        public DbSet<Tops> Tops { get; set; }
        public DbSet<Pants> Pants { get; set; }
        public DbSet<Shoes> Shoes { get; set; }
    }
}
