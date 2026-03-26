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
        public ChangeCard()
        {
            InitializeComponent();
            textBoxName.KeyDown += TextBoxName_KeyDown;
            buttonChange.Click += ButtonChange_Click;
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var input = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Resources.NameProduct", Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                Product product = null;
                if (Guid.TryParse(input, out Guid id))
                {
                    product = db.Products.FirstOrDefault(p => p.Id == id);
                }
                else
                {
                    string search = input.ToLower();
                    product = db.Products.FirstOrDefault(p => p.Name.ToLower() == search);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Сначала найдите товар", Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId.Text.Trim(), out int count))
            {
                MessageBox.Show("Введите корректное число для art", Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxUnit.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Введите корректное число для количества", Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxPrice.Text.Trim(), out int rest))
            {
                MessageBox.Show("Введите корректное число для цены", Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBProducts())
            {
                var productToUpdate = db.Products.FirstOrDefault(p => p.Id == currentProduct.Id);
                if (productToUpdate != null)
                {
                    productToUpdate.Count = count;
                    productToUpdate.Price = price;
                    productToUpdate.Rest = rest;
                    db.SaveChanges();
                    MessageBox.Show("Информация успешно обновлена",Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void TextBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                e.Handled = true;
                ButtonSearch_Click(sender, EventArgs.Empty);
            }
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            var changeCardform = new ChangeCard();
            changeCardform.Show();
            Hide();
        }
    }
}
