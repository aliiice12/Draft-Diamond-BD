using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class DeleteCard : Form
    {
        private DataGridView dgvWarehouse; 
        public DeleteCard(DataGridView dgv)
        {
            InitializeComponent();
            dgvWarehouse = dgv;
            buttonDelete.Click += ButtonDelete_Click;
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show(Resources.ID, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Guid.TryParse(textBoxId.Text, out Guid productId))
            {
                MessageBox.Show(Resources.GuidID, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == productId);
                if (product == null)
                {
                    MessageBox.Show(Resources.NotDatabase, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.Products.Remove(product);
                db.SaveChanges();
                MessageBox.Show(Resources.DeleteProduct, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxId.Clear();
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            if (dgvWarehouse == null) return;

            using (var db = new DBProducts())
            {
                dgvWarehouse.DataSource = db.Products.ToList();
            }
        }
    }
}
