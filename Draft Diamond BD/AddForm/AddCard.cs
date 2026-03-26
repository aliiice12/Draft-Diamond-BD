using Draft_Diamond_BD.DataBaseProducts;
using Draft_Diamond_BD.Products;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class AddCard : Form
    {
        public AddCard()
        {
            InitializeComponent();
            buttonAdd.Click += ButtonAdd_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||string.IsNullOrWhiteSpace(textBoxUnit.Text) ||string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show(Resources.FillFields, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(textBoxPrice.Text, out decimal totalPurchase))
            {
                MessageBox.Show(Resources.Price, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                var productFromDb = db.Products.FirstOrDefault(p => p.Name == textBoxName.Text);
                if (productFromDb == null)
                {
                    MessageBox.Show(Resources.NotDatabase, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal unitPrice = productFromDb.Price;
                var count = (int)Math.Floor(totalPurchase / unitPrice);
                productFromDb.Count += count;
                productFromDb.Rest += count;
                db.SaveChanges();
            }
            MessageBox.Show(Resources.AddProduct, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Clear();
            textBoxUnit.Clear();
            textBoxPrice.Clear();
        }
        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.AddProduct, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

