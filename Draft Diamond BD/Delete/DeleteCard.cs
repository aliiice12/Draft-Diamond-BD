using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class DeleteCard : Form
    {
        public DeleteCard()
        {
            InitializeComponent();
            buttonDelete.Click += ButtonDelete_Click;
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Resources.EnterID");
                return;
            }
            if (!Guid.TryParse(textBoxId.Text, out Guid productId))
            {
                MessageBox.Show("Resources.GuidID");
                return;
            }
            using (var db = new DBProducts())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == productId);

                if (product == null)
                {
                    MessageBox.Show("Resources.NotDatabase");
                    return;
                }
                db.Products.Remove(product);
                db.SaveChanges();
                MessageBox.Show(Resources.DeleteProduct);
                textBoxId.Clear();
            }
        }
    }
}
