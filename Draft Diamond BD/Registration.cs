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
            var name = textBoxName.Text.Trim();
            var surname = textBoxSurname.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show(Resources.EnterTheCorrectInformation); 
                return;
            }
            using (var db = new DBWorkers())
            {
                var existingUser = db.Workers.FirstOrDefault(w => w.Login == login);
                if (existingUser != null)
                {
                    MessageBox.Show(Resources.SuchLogin); 
                    return;
                }
                var newWorker = new Worker()
                {
                    Login = login,
                    Password = password,
                    Name = name,
                    Surname = surname
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

