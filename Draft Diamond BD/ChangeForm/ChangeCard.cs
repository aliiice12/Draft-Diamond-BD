using Draft_Diamond_BD.DataBaseProducts;
using Draft_Diamond_BD.Products;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class ChangeCard : Form
    {
        private Product currentProduct; 
        private DataGridView dgvWarehouse; 
        public ChangeCard(DataGridView dgv)
        {
            InitializeComponent();
            dgvWarehouse = dgv;
            textBoxId.KeyDown += TextBoxId_KeyDown; 
            buttonChange.Click += ButtonChange_Click;
        }
        private void TextBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                LoadProductById();
            }
        }
        private void LoadProductById()
        {
            if (!Guid.TryParse(textBoxId.Text.Trim(), out Guid id))
            {
                MessageBox.Show(Resources.ID, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                currentProduct = db.Products.FirstOrDefault(p => p.Id == id);
                if (currentProduct == null)
                {
                    MessageBox.Show(Resources.NotDatabase,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBoxName.Text = currentProduct.Name;
                textBoxUnit.Text = currentProduct.Count.ToString();
                textBoxPrice.Text = currentProduct.Price.ToString();
            }
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show(Resources.FindProduct,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxUnit.Text.Trim(), out int count))
            {
                MessageBox.Show(Resources.NumberCount, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show(Resources.PurchasePrice, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxPrice.Text.Trim(), out int rest))
            {
                MessageBox.Show(Resources.NumberRest, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                var productToUpdate = db.Products.FirstOrDefault(p => p.Id == currentProduct.Id);
                if (productToUpdate != null)
                {
                    productToUpdate.Name = textBoxName.Text.Trim();
                    productToUpdate.Count = count;
                    productToUpdate.Price = price;
                    productToUpdate.Rest = rest;
                    db.SaveChanges();
                    MessageBox.Show(Resources.InformationSuccess,Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                }
            }
        }
        private void RefreshDataGrid()
        {
            using (var db = new DBProducts())
            {
                dgvWarehouse.DataSource = db.Products.ToList();
            }
        }
    }
}

