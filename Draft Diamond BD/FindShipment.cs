using Draft_Diamond_BD.DataBase;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class FindShipment : Form
    {
        public FindShipment()
        {
            InitializeComponent();
            buttonSearch.Click += ButtonSearch_Click;
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string idText = textBoxID.Text.Trim();
            string name = textBoxName.Text.Trim();

            using (var db = new DBShipment())
            {
                var query = db.Shipments.AsQueryable();
                if (Guid.TryParse(idText, out Guid id))
                    query = query.Where(s => s.Id == id);
                if (!string.IsNullOrWhiteSpace(name))
                    query = query.Where(s => s.Name.Contains(name));
                var result = query.ToList();

                if (result.Count == 0)
                {
                    MessageBox.Show(Resources.NotFoundShipment);
                    return;
                }
                var resultForm = new DBShipmentForm(result);
                resultForm.Show();
            }
        }
    }
}
        
    

