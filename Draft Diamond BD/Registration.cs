using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.Workers;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (var db = new DBWorkers())
            {
                var user = db.Workers.FirstOrDefault(w => w.Login == login);
                if (user != null)
                {
                    MessageBox.Show("Такой пользователь уже существует");
                    return;
                }

                string hashedPassword = HashPassword(password);

                var newWorker = new Worker()
                {
                    Login = login,
                    Password = hashedPassword
                };

                db.Workers.Add(newWorker);
                db.SaveChanges();
            }

            MessageBox.Show("Регистрация успешна");
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

