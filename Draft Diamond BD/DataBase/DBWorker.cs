using Draft_Diamond_BD.Workers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
namespace Draft_Diamond_BD.DataBase
{
    public class DBWorkers : DbContext
    {
        public DbSet<Worker> Workers { get; set; }

        public DBWorkers()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания БД: {ex.Message}");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=worker.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Workers");
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Login);
                entity.Property(s => s.Password);
                entity.Property(s => s.Name);
                entity.Property(s => s.Surname);
                entity.Property(s => s.Job);

            });
        }
    }
}