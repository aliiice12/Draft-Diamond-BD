using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Draft_Diamond_BD.SearchCard;
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
                var products = db.Products.Where(p => p.Name == category).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        private void LoadProducts()
        {
            using (var db = new DBProducts())
            {
                var products = db.Products.ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns["Id"] != null)
                dgvWarehouse.Columns["Id"].HeaderText = "ID";

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
            var createform = new CreatingShipment();
            createform.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
