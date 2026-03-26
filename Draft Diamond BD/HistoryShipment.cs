using Draft_Diamond_BD.DataBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class HistoryShipment : Form
    {
        private DataGridView dgvHistory;
        private string userLogin;
        public HistoryShipment(string login)
        {
            InitializeComponent();
            CreateDataGridView();
            LoadHistory();
            userLogin = login;
            searchtoolStripMenuItem.Click += SearchtoolStripMenuItem_Click;
            buttonListProduct.Click += ButtonListProduct_Click;
        }
        private void CreateDataGridView()
        {
            dgvHistory = new DataGridView
            {
                Location = new System.Drawing.Point(90, 320),
                Size = new System.Drawing.Size(860, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
            };

            Controls.Add(dgvHistory);
        }
        private void ButtonListProduct_Click(object sender, EventArgs e)
        {
            var warehouseform = new WarehouseAdmin(userLogin);
            warehouseform.Show();
            Hide();
        }
        private void SearchtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchform = new SearchProducts();
            searchform.Show();
            Hide();
        }
        private void LoadHistory()
        {
            using (var db = new DBShipment())
            {
                dgvHistory.AutoGenerateColumns = true;
                dgvHistory.DataSource = db.Shipments.ToList();

                if (dgvHistory.Columns["Id"] != null)
                    dgvHistory.Columns["Id"].HeaderText = "ID отгрузки";

                if (dgvHistory.Columns["Name"] != null)
                    dgvHistory.Columns["Name"].HeaderText = "Название";

                if (dgvHistory.Columns["Unit"] != null)
                    dgvHistory.Columns["Unit"].HeaderText = "Ед. изм.";

                if (dgvHistory.Columns["Quantity"] != null)
                    dgvHistory.Columns["Quantity"].HeaderText = "Количество";

                if (dgvHistory.Columns["Destination"] != null)
                    dgvHistory.Columns["Destination"].HeaderText = "Куда";

                if (dgvHistory.Columns["Recipient"] != null)
                    dgvHistory.Columns["Recipient"].HeaderText = "Кому";
            }
        }
    }
}
