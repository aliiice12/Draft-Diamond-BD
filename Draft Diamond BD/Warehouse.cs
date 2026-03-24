using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class Warehouse : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public Warehouse(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = userLogin;
            CreateDataGridView();
            LoadProducts();
            toolStripMenuItemCreatingShipment.Click += ToolStripMenuItemCreatingShipment_Click;
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProducts();
            кольцоToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Ring);
            серьгиToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Earring);
            браслетToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Bracelet);
            кольеToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Necklace);
            брошьToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Brooch);
            выходToolStripMenuItemOutput.Click += Exit_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(90, 320),
                Size = new System.Drawing.Size(860, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
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
        private void ToolStripMenuItemCreatingShipment_Click(object sender, EventArgs e)
        {
            var createform = new CreatingShipment();
            createform.Show();
            Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InitializeComponent()
        {
            this.labelwarehouse = new System.Windows.Forms.Label();
            this.menuStripWarehouseProducts = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCreatingShipment = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItemOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLogin = new System.Windows.Forms.Label();
            this.весьСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серьгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.браслетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кольеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWarehouseProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelwarehouse
            // 
            this.labelwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelwarehouse.AutoSize = true;
            this.labelwarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwarehouse.Location = new System.Drawing.Point(12, 90);
            this.labelwarehouse.Name = "labelwarehouse";
            this.labelwarehouse.Size = new System.Drawing.Size(115, 36);
            this.labelwarehouse.TabIndex = 0;
            this.labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            this.menuStripWarehouseProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripWarehouseProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreatingShipment,
            this.поискToolStripMenuItemSearch,
            this.фильтрToolStripMenuItemFilter,
            this.выходToolStripMenuItemOutput});
            this.menuStripWarehouseProducts.Location = new System.Drawing.Point(0, 0);
            this.menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            this.menuStripWarehouseProducts.Size = new System.Drawing.Size(732, 28);
            this.menuStripWarehouseProducts.TabIndex = 1;
            this.menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItemCreatingShipment
            // 
            this.toolStripMenuItemCreatingShipment.Name = "toolStripMenuItemCreatingShipment";
            this.toolStripMenuItemCreatingShipment.Size = new System.Drawing.Size(140, 24);
            this.toolStripMenuItemCreatingShipment.Text = "Создать отгрузку";
            // 
            // поискToolStripMenuItemSearch
            // 
            this.поискToolStripMenuItemSearch.Name = "поискToolStripMenuItemSearch";
            this.поискToolStripMenuItemSearch.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItemSearch.Text = "Поиск";
            // 
            // фильтрToolStripMenuItemFilter
            // 
            this.фильтрToolStripMenuItemFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весьСкладToolStripMenuItem,
            this.кольцоToolStripMenuItem,
            this.серьгиToolStripMenuItem,
            this.браслетToolStripMenuItem,
            this.кольеToolStripMenuItem,
            this.брошьToolStripMenuItem});
            this.фильтрToolStripMenuItemFilter.Name = "фильтрToolStripMenuItemFilter";
            this.фильтрToolStripMenuItemFilter.Size = new System.Drawing.Size(74, 24);
            this.фильтрToolStripMenuItemFilter.Text = "Фильтр";
            // 
            // выходToolStripMenuItemOutput
            // 
            this.выходToolStripMenuItemOutput.Name = "выходToolStripMenuItemOutput";
            this.выходToolStripMenuItemOutput.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItemOutput.Text = "Выход";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(656, 3);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 25);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "label1";
            // 
            // весьСкладToolStripMenuItem
            // 
            this.весьСкладToolStripMenuItem.Name = "весьСкладToolStripMenuItem";
            this.весьСкладToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.весьСкладToolStripMenuItem.Text = "Весь склад";
            // 
            // кольцоToolStripMenuItem
            // 
            this.кольцоToolStripMenuItem.Name = "кольцоToolStripMenuItem";
            this.кольцоToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кольцоToolStripMenuItem.Text = "Кольцо";
            // 
            // серьгиToolStripMenuItem
            // 
            this.серьгиToolStripMenuItem.Name = "серьгиToolStripMenuItem";
            this.серьгиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.серьгиToolStripMenuItem.Text = "Серьги";
            // 
            // браслетToolStripMenuItem
            // 
            this.браслетToolStripMenuItem.Name = "браслетToolStripMenuItem";
            this.браслетToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.браслетToolStripMenuItem.Text = "Браслет";
            // 
            // кольеToolStripMenuItem
            // 
            this.кольеToolStripMenuItem.Name = "кольеToolStripMenuItem";
            this.кольеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кольеToolStripMenuItem.Text = "Колье";
            // 
            // брошьToolStripMenuItem
            // 
            this.брошьToolStripMenuItem.Name = "брошьToolStripMenuItem";
            this.брошьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.брошьToolStripMenuItem.Text = "Брошь";
            // 
            // Warehouse
            // 
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelwarehouse);
            this.Controls.Add(this.menuStripWarehouseProducts);
            this.MainMenuStrip = this.menuStripWarehouseProducts;
            this.Name = "Warehouse";
            this.menuStripWarehouseProducts.ResumeLayout(false);
            this.menuStripWarehouseProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
