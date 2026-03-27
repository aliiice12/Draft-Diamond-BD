using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class AddCard : Form
    {
        private WarehouseAdmin _warehouseAdmin;
        private DatabaseProduct _databaseProduct;
        public AddCard()
        {
            InitializeComponent();
            buttonAdd.Click += BtnSave_Click;
        }
        public AddCard(WarehouseAdmin warehouseAdmin)
        {
            _warehouseAdmin = warehouseAdmin;
        }
        public AddCard(DatabaseProduct databaseProduct) 
        {
            _databaseProduct = databaseProduct;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show(Resources.NameAndPrice,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out decimal purchasePrice))
            {
                MessageBox.Show(Resources.PurchasePrice,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                var productFromDb = db.Products.FirstOrDefault(p => p.Name == textBoxName.Text.Trim());
                if (productFromDb == null)
                {
                    MessageBox.Show(Resources.PiceOne,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal rawCount = purchasePrice / productFromDb.Price;
                int count;
                if (!int.TryParse(Math.Floor(rawCount).ToString(), out count))
                {
                    MessageBox.Show(Resources.Calculation,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                productFromDb.Count += count;
                productFromDb.Rest += count;
                db.SaveChanges();
            }
            textBoxName.Clear();
            textBoxUnit.Clear(); 
            textBoxPrice.Clear();
            if (_warehouseAdmin != null)
                _warehouseAdmin.LoadProducts();
            else if (_databaseProduct != null)
                _databaseProduct.ShowAllProducts();
            MessageBox.Show(Resources.AddProduct,Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.AddProduct, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

