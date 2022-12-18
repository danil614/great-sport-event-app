using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLogin.Text) || string.IsNullOrWhiteSpace(textPassword.Text))
                MessageBox.Show(@"Пустой логин или пароль!");
            else
                MessageBox.Show(@"Подключение к базе данных!");
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLogin_Click(sender, e);
        }
    }
}