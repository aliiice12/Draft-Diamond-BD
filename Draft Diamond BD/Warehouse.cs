using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class Warehouse : Form
    {
        private DataGridView dgvWarehouse;
        public Warehouse()
        {
            InitializeComponent();
            CreateDataGridView();
            ring.Click += ring_Click;
            earrings.Click += earrings_Click;
            bracelet.Click += bracelet_Click;
            necklace.Click += necklace_Click;
            brooch.Click += brooch_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(12, 120),
                Size = new System.Drawing.Size(560, 350),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.White
            };
            Controls.Add(dgvWarehouse);
        }
        private void ring_Click(object sender, EventArgs e)
        {
            LoadProducts("Кольцо");
        }
        private void earrings_Click(object sender, EventArgs e)
        {
            LoadProducts("Серьги");
        }
        private void bracelet_Click(object sender, EventArgs e)
        {
            LoadProducts("Браслет");
        }
        private void necklace_Click(object sender, EventArgs e)
        {
            LoadProducts("Колье");
        }
        private void brooch_Click(object sender, EventArgs e)
        {
            LoadProducts("Брошь");
        }
        private void LoadProducts(string productName)
        {
            using (DBProducts db = new DBProducts())
            {
                var products = db.Products.Where(p => p.Name == productName).ToList();
                dgvWarehouse.DataSource = null;
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

        private void InitializeComponent()
        {
            warehouseProducts = new Label();
            ring = new Button();
            earrings = new Button();
            bracelet = new Button();
            necklace = new Button();
            brooch = new Button();
            SuspendLayout();

            //warehouseProducts

            warehouseProducts.AutoSize = true;
            warehouseProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            warehouseProducts.Location = new System.Drawing.Point(142, 9);
            warehouseProducts.Name = "warehouseProducts";
            warehouseProducts.Size = new System.Drawing.Size(271, 32);
            warehouseProducts.TabIndex = 6;
            warehouseProducts.Text = "СКЛАД ТОВАРОВ";

           // ring

            ring.Location = new System.Drawing.Point(4, 64);
            ring.Name = "ring";
            ring.Size = new System.Drawing.Size(96, 29);
            ring.TabIndex = 7;
            ring.Text = "КОЛЬЦО";
            ring.UseVisualStyleBackColor = true;

            //earrings

            earrings.Location = new System.Drawing.Point(106, 64);
            earrings.Name = "earrings";
            earrings.Size = new System.Drawing.Size(115, 29);
            earrings.TabIndex = 8;
            earrings.Text = "СЕРЬГИ";
            earrings.UseVisualStyleBackColor = true;

            //bracelet


            bracelet.Location = new System.Drawing.Point(227, 64);
            bracelet.Name = "bracelet";
            bracelet.Size = new System.Drawing.Size(120, 29);
            bracelet.TabIndex = 9;
            bracelet.Text = "БРАСЛЕТ";
            bracelet.UseVisualStyleBackColor = true;

            //necklace

            necklace.Location = new System.Drawing.Point(353, 64);
            necklace.Name = "necklace";
            necklace.Size = new System.Drawing.Size(101, 29);
            necklace.TabIndex = 10;
            necklace.Text = "КОЛЬЕ";
            necklace.UseVisualStyleBackColor = true;

            //brooch

            brooch.Location = new System.Drawing.Point(460, 64);
            brooch.Name = "brooch";
            brooch.Size = new System.Drawing.Size(127, 30);
            brooch.TabIndex = 11;
            brooch.Text = "БРОШЬ";
            brooch.UseVisualStyleBackColor = true;

            //Warehouse

            ClientSize = new System.Drawing.Size(599, 517);
            Controls.Add(brooch);
            Controls.Add(necklace);
            Controls.Add(bracelet);
            Controls.Add(earrings);
            Controls.Add(ring);
            Controls.Add(warehouseProducts);
            Name = "Warehouse";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
