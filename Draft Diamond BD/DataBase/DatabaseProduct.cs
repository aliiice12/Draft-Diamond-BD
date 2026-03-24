using Draft_Diamond_BD.DataBaseProducts;
using Draft_Diamond_BD.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class DatabaseProduct : Form
    {
        public DatabaseProduct(string searchText)
        {
            InitializeComponent();
            CreateDataGridView();
            AddData();
            var products = GetProductsFromDatabase().Where(p => p.Name.Contains(searchText)).ToList();   
        }
        private void CreateDataGridView()
        {
            dgvProducts = new DataGridView
            {
                Location = new Point(12, 12),
                Size = new Size(760, 400),
                BackgroundColor = Color.White
            };
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Controls.Add(dgvProducts); 
        }
        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScroll = true;
            ClientSize = new Size(413, 291);
            Name = "DatabaseProduct";
            StartPosition = FormStartPosition.Manual;
            Text = "Управление товарами";
            ResumeLayout(false);

        }
        private List<Product> GetProductsFromDatabase()
        {
            using (var db = new DBProducts())
            {
                return db.Products.ToList();
            }
        }
        private void ConfigureDataGridViewColumns()
        {
            if (dgvProducts.Columns.Count > 0)
            {
                dgvProducts.Columns["Id"].HeaderText = "ID";
                dgvProducts.Columns["Id"].Width = 200;

                dgvProducts.Columns["Name"].HeaderText = "Название";
                dgvProducts.Columns["Name"].Width = 200;

                dgvProducts.Columns["Count"].HeaderText = "Количество";
                dgvProducts.Columns["Count"].Width = 100;
                dgvProducts.Columns["Count"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvProducts.Columns["Price"].HeaderText = "Цена";
                dgvProducts.Columns["Price"].Width = 120;
                dgvProducts.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvProducts.Columns["Rest"].HeaderText = "Остаток";
                dgvProducts.Columns["Rest"].Width = 100;
                dgvProducts.Columns["Rest"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        private void AddData()
        {
            using (var db = new DBProducts())
            {
                if (!db.Products.Any())
                {
                    db.Products.AddRange(new Product[]
                    {
                    new Product { Id = Guid.NewGuid(), Name = "Кольцо", Count = 15, Price = 45000m, Rest = 800 },
                    new Product { Id = Guid.NewGuid(), Name = "Серьги", Count = 30, Price = 12000m, Rest = 2500 },
                    new Product { Id = Guid.NewGuid(), Name = "Колье", Count = 20, Price = 35000m, Rest = 1200 },
                    new Product { Id = Guid.NewGuid(), Name = "Браслет", Count = 8, Price = 18500m, Rest = 300 },
                     new Product { Id = Guid.NewGuid(), Name = "Брошь", Count = 100, Price = 5000m, Rest = 800 },
                    });

                    db.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Метод для поиска информации в базе данных
        /// </summary>
        /// <param name="products"></param>
        public void ShowSearchResult(List<Product> products)
        {
            dgvProducts.DataSource = products;
            ConfigureDataGridViewColumns();
        }
    }
}
