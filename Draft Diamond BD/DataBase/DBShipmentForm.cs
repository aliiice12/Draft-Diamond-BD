using System.Collections.Generic;
using System.Windows.Forms;

namespace Draft_Diamond_BD.DataBase
{
    public partial class DBShipmentForm : Form
    {
        private DataGridView dgvResults;
        public DBShipmentForm(List<DBShipmentClass> shipments)
        {
            InitializeComponent();

            dgvResults = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.White
            };
            Controls.Add(dgvResults);
            dgvResults.DataSource = shipments;
            if (dgvResults.Columns["Id"] != null)
                dgvResults.Columns["Id"].HeaderText = "ID отгрузки";
            if (dgvResults.Columns["Name"] != null)
                dgvResults.Columns["Name"].HeaderText = "Название";
            if (dgvResults.Columns["Unit"] != null)
                dgvResults.Columns["Unit"].HeaderText = "Ед. изм.";
            if (dgvResults.Columns["Quantity"] != null)
                dgvResults.Columns["Quantity"].HeaderText = "Количество";
            if (dgvResults.Columns["Destination"] != null)
                dgvResults.Columns["Destination"].HeaderText = "Куда";
            if (dgvResults.Columns["Recipient"] != null)
                dgvResults.Columns["Recipient"].HeaderText = "Кому";
        }
    }
}
