using Microsoft.EntityFrameworkCore;
using Draft_Diamond_BD.Products;

namespace Draft_Diamond_BD.DataBaseProducts
{
    public class DBProducts : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DBProducts()
        {
            Database.EnsureCreated(); // Создает БД при первом запуске
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=productss.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>().ToTable("Products");//таблица
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.Count);
                entity.Property(p => p.Price);
                entity.Property(p => p.Rest);
            });
        }
    }

}
