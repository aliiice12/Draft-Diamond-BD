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
        public DataGridView HistoryGrid => dgvHistory;
        public HistoryShipment(string login)
        {
            InitializeComponent();
            CreateDataGridView();
            LoadHistory();
            userLogin = Resources.LoginInMenu + login;
            searchtoolStripMenuItem.Click += SearchtoolStripMenuItem_Click;
            buttonListProduct.Click += ButtonListProduct_Click;
        }
        private void CreateDataGridView()
        {
            dgvHistory = new DataGridView
            {
                Location = new System.Drawing.Point(10, 150),
                Size = new System.Drawing.Size(700, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
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
            var searchShipment = new SearchShipment();
            searchShipment.Show();
            Hide();
        }
        private void LoadHistory()
        {
            using (var db = new DBShipmentBasket())
            {
                dgvHistory.DataSource = db.Shipments.Select(p => new
                {
                    p.Name,
                    p.Unit,
                    p.Quantity,
                    p.Destination,
                    p.Recipient,
                }).ToList();
                SetupColumns();
            }
        }
        private void SetupColumns()
        {

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
