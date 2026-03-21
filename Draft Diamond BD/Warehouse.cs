using Draft_Diamond_BD.DataBaseProducts;
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
            LoadProducts();
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(100, 320),
                Size = new System.Drawing.Size(860, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.White,
                ReadOnly = true,
                AllowUserToAddRows = false
            };

            Controls.Add(dgvWarehouse);
        }
        private void LoadProducts()
        {
            using (DBProducts db = new DBProducts())
            {
                var products = db.Products.ToList();

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
            this.labelwarehouse = new System.Windows.Forms.Label();
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
            // Warehouse
            // 
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.labelwarehouse);
            this.Name = "Warehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
