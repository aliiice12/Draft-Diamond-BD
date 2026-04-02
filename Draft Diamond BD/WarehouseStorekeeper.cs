using Draft_Diamond_BD.DataBaseProducts;
using Draft_Diamond_BD.Products;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class WarehouseStorekeeper : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public WarehouseStorekeeper(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = userLogin;
            CreateDataGridView();
            AddData();
            LoadProducts();
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProducts();
            кольцоToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Ring);
            серьгиToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Earring);
            браслетToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Bracelet);
            кольеToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Necklace);
            брошьToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Brooch);
            exitToolStripMenuItemOutput.Click += Exit_Click;
            searchToolStripMenuItem.Click += SearchToolStripMenuItem_Click;
            createShipmentToolStripMenuItem.Click += CreateShipmentToolStripMenuItem_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new Point(90, 320),
                Size = new Size(860, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.DarkGray,
            };
            Controls.Add(dgvWarehouse);
        }
        private void FilterProducts(string category)
        {
            using (var db = new DBProducts())
            {
                var products = db.Products
                    .Where(p => p.Name.Contains(category))
                    .Select(p => new
                    {
                        p.Name,
                        p.Count,
                        p.Price,
                        p.Rest,
                    }).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void LoadProducts()
        {
            using (var db = new DBProducts())
            {
                dgvWarehouse.DataSource = db.Products
                    .Select(p => new {p.Name, p.Count, p.Price, p.Rest })
                    .ToList();
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
        private void SetupColumns()
        {

            if (dgvWarehouse.Columns["Name"] != null)
                dgvWarehouse.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouse.Columns["Count"] != null)
                dgvWarehouse.Columns["Count"].HeaderText = "Количество";

            if (dgvWarehouse.Columns["Price"] != null)
                dgvWarehouse.Columns["Price"].HeaderText = "Цена";

            if (dgvWarehouse.Columns["Rest"] != null)
                dgvWarehouse.Columns["Rest"].HeaderText = "Остаток";

        }
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchCard();
            searchForm.Show();
        }
        private void CreateShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createform = new CreatingShipment(userLogin);
            createform.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
