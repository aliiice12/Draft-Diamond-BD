using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.Workers;
using System;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            buttonRegister.Click += buttonRegister_Click;
            btnAuthorization.Click += btnAuthorization_Click;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBWorkers())
                {
                    var loginExists = false;
                    foreach (var w in db.Workers)
                    {
                        if (w.Login == textBoxLogin.Text)
                        {
                            loginExists = true;
                            break;
                        }
                    }
                    if (loginExists)
                    {
                        MessageBox.Show(Resources.SuchLogin);
                        return;
                    }
                    var newWorker = new Worker()
                    {
                        Id = Guid.NewGuid(),
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        Job = Jobs.Storekeeper
                    };
                    db.Workers.Add(newWorker);
                    db.SaveChanges();
                    MessageBox.Show(Resources.UserRegistreted,Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var authForm = new Authorization();
                    authForm.Show();
                    Hide(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.RegistrationError,Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            var authForm = new Authorization();
            authForm.Show();
            Hide();
        }
    }
}
