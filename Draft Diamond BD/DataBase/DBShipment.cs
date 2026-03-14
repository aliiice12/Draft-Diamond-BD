using Microsoft.EntityFrameworkCore;
namespace Draft_Diamond_BD.DataBase
{
    public class DBShipment : DbContext
    {
        public DbSet<DBShipmentClass> Shipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shipment.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBShipmentClass>(entity =>
            {
                entity.ToTable("Shipments");
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name);
                entity.Property(s => s.Unit);
                entity.Property(s => s.Quantity);
            });
        }
    }
}

