using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.Workers;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            buttonRegister.Click += btnCreate_Click;
            btnAuthorization.Click += btnAuthorization_Click;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(Resources.EnterTheCorrectInformation);
                return;
            }
            using (var db = new DBWorkers())
            {
                var user = db.Workers.FirstOrDefault(w => w.Login == login);
                if (user != null)
                {
                    MessageBox.Show(Resources.SuchLogin);
                    return;
                }
                var newWorker = new Worker()
                {
                    Login = login,
                    Password = password
                };

                db.Workers.Add(newWorker);
                db.SaveChanges();
            }
            MessageBox.Show(Resources.Success);
            new Authorization().Show();
            Hide();
        }
        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            Hide();
        }
    }
}

