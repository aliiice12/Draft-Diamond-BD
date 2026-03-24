using Draft_Diamond_BD.DataBase;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            enter.Click += enter_Click;
            btnRegister.Click += btnRegister_Click;
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
        private void enter_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (var db = new DBWorkers())
            {
                string hashedPassword = HashPassword(password);

                var user = db.Workers
                    .FirstOrDefault(w => w.Login == login && w.Password == hashedPassword);

                if (user != null)
                {
                    Warehouse warehouseForm = new Warehouse(user.Login);
                    warehouseForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration regForm = new Registration();
            regForm.Show();
            Hide();
        }
    }
}
