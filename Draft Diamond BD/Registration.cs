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
            btnRegister.Click += btnRegister_Click;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBWorkers db = new DBWorkers())
                {
                    bool loginExists = false;

                    foreach (Worker w in db.Workers)
                    {
                        if (w.Login == textBoxLogin.Text)
                        {
                            loginExists = true;
                            break;
                        }
                    }
                    if (loginExists)
                    {
                        MessageBox.Show("Такой логин уже существует");
                        return;
                    }
                    Worker newWorker = new Worker()
                    {
                        Id = Guid.NewGuid(),
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        Job = Jobs.Кладовщик 
                    };

                    db.Workers.Add(newWorker);
                    db.SaveChanges();

                    MessageBox.Show("Пользователь успешно зарегистрирован!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Authorization authForm = new Authorization();
                    authForm.Show();
                    Hide(); // закрываем форму регистрации
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Authorization authForm = new Authorization();
            authForm.Show();
            Hide(); 
        }
    }
}
