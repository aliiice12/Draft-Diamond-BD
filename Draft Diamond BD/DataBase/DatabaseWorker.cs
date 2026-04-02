using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.Workers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class DatabaseWorker : Form
    {
        private DataGridView dgvWorkers;

        public DatabaseWorker()
        {
            InitializeComponent();
            CreateDataGridView();
            EnsureAdminsExist();
            RefreshDataGridView();
        }
        private void CreateDataGridView()
        {
            dgvWorkers = new DataGridView
            {
                Location = new Point(12, 12),
                Size = new Size(500, 500),
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };
            dgvWorkers.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvWorkers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Controls.Add(dgvWorkers);
        }
        private void InitializeComponent()
        {
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "DatabaseWorker";
            Text = "Работники склада";
        }
        private List<Worker> GetWorkersFromDatabase()
        {
            using (var db = new DBWorkers())
            {
                return db.Workers.ToList();
            }
        }
        private void RefreshDataGridView()
        {
            var workers = GetWorkersFromDatabase();
            dgvWorkers.DataSource = null;
            dgvWorkers.DataSource = workers;
        }
        private static void EnsureAdminsExist()
        {
            using (var db = new DBWorkers())
            {
                if (!db.Workers.Any(w => w.Login == "777"))
                {
                    db.Workers.Add(new Admin("777", "888", "Admin", "One"));
                }

                if (!db.Workers.Any(w => w.Login == "012"))
                {
                    db.Workers.Add(new Admin("012", "8642", "Admin", "Two"));
                }

                db.SaveChanges();
            }
        }
        
    }
}