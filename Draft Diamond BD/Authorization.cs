using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.Workers;
using System;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            enter.Click += enter_Click;
        }
        private void enter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool userFound = false;
            using (DBWorkers db = new DBWorkers())
            {
                foreach (Worker w in db.Workers)
                {
                    if (w.Login == login && w.Password == password)
                    {
                        userFound = true;
                        break;
                    }
                }
            }
            if (userFound)
            {
                Warehouse warehouseForm = new Warehouse();
                warehouseForm.Show();   // открыть форму склада
                Hide(); // скрыть форму авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
