using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.HashPassword;
using Draft_Diamond_BD.Workers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            EnsureAdminsExist();
            enter.Click += enter_Click;
            btnRegister.Click += btnRegister_Click;
        }
        private void enter_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = SimpleHash.HashSHA256(txtPassword.Text.Trim());

            using (var db = new DBWorkers())
            {
                var user = db.Workers.FirstOrDefault(w => w.Login == login);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        if (user.Job == Jobs.Administrator)
                        {
                            var warehouseAdminForm = new WarehouseAdmin(user.Login);
                            warehouseAdminForm.Show();
                        }
                        else
                        {
                            var warehouseStorekeeperForm = new WarehouseStorekeeper(user.Login);
                            warehouseStorekeeperForm.Show();
                        }
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show(Resources.ErrorLogin);
                }
            }
        }
        private void EnsureAdminsExist()
        {
            using (var db = new DBWorkers())
            {
                if (!db.Workers.Any(w => w.Login == "789"))
                {
                    db.Workers.Add(new Admin(Guid.NewGuid(), "789", "888", "Admin", "One"));
                }

                if (!db.Workers.Any(w => w.Login == "012"))
                {
                    db.Workers.Add(new Admin(Guid.NewGuid(), "012", "8642", "Admin", "Two"));
                }

            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerform = new Registration();
            registerform.Show();
            Hide();
        }
    }
}