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

            if (!string.IsNullOrEmpty(searchText))
            {
                var products = GetProductsFromDatabase()
                    .Where(p => p.Name.Contains(searchText))
                    .ToList();

                ShowSearchResult(products);
            }
            else
            {
                ShowAllProducts();
            }
        }
        public DatabaseProduct()
        {
            InitializeComponent();
            CreateDataGridView();
            AddData();
            ShowAllProducts();
        }
        /// <summary>
        /// Метод для отображения всех товаров из базы данных
        /// </summary>
        public void ShowAllProducts()
        {
            using (var db = new DBProducts())
            {
                var products = db.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Count,
                        p.uniteOfMeasure,
                        p.Price,
                        p.Rest
                    })
                    .ToList();
                dgvProducts.DataSource = products;
                ConfigureDataGridViewColumns();
            }
        }
        private void CreateDataGridView()
        {
            dgvProducts = new DataGridView
            {
                Location = new Point(12, 12),
                Size = new Size(760, 400),
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.EnableHeadersVisualStyles = false;

            Controls.Add(dgvProducts);
        }
        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Name = "DatabaseProduct";
            StartPosition = FormStartPosition.CenterScreen;
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
                dgvProducts.Columns["Name"].HeaderText = "Название";
                dgvProducts.Columns["uniteOfMeasure"].HeaderText = "Ед.измерения";
                dgvProducts.Columns["Count"].HeaderText = "Количество";
                dgvProducts.Columns["Price"].HeaderText = "Цена";
                dgvProducts.Columns["Rest"].HeaderText = "Остаток";

                dgvProducts.Columns["Count"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                        new Product { Id = Guid.NewGuid(), Name = "Кольцо", Count = 15, uniteOfMeasure = UniteOfMeasure.Unit, Price = 45000m, Rest = 800 },
                        new Product { Id = Guid.NewGuid(), Name = "Серьги", Count = 30, uniteOfMeasure = UniteOfMeasure.Unit, Price = 12000m, Rest = 2500 },
                        new Product { Id = Guid.NewGuid(), Name = "Колье", Count = 20, uniteOfMeasure = UniteOfMeasure.Unit, Price = 35000m, Rest = 1200 },
                        new Product { Id = Guid.NewGuid(), Name = "Браслет", Count = 8, uniteOfMeasure = UniteOfMeasure.Unit, Price = 18500m, Rest = 300 },
                        new Product { Id = Guid.NewGuid(), Name = "Брошь", Count = 100, uniteOfMeasure = UniteOfMeasure.Unit, Price = 5000m, Rest = 800 },
                    });
                    db.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Метод для нахождения нужных товаров из базы данных
        /// </summary>
        /// <param name="products"></param>
        public void ShowSearchResult(List<Product> products)
        {
            dgvProducts.DataSource = products.Select(p => new
            {
                p.Name,
                p.Count,
                p.uniteOfMeasure,
                p.Price,
                p.Rest
            }).ToList();

            ConfigureDataGridViewColumns();
        }
    }
}

