using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp
{
    public partial class AdminForm : DockContent
    {
        public AdminForm()
        {
            InitializeComponent();
            UpdateListUsers();
            
            // Запрещаем редактирование режима доступа
            comboMode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        ///     Обновляет список мест.
        /// </summary>
        private void UpdateListUsers()
        {
            // Получаем запрос со зрителями
            var listUsers = Query.GetListUsers(out var isConnected);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataUsers.DataSource = listUsers;
            }

            // Растягиваем колонки
            dataUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var isConnected = Query.InsertUser(textLogin.Text, textPassword.Text, comboMode.Text);
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            UpdateListUsers();
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            var isConnected = Query.UpdateUser(textLogin.Text, textPassword.Text, comboMode.Text);
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            UpdateListUsers();
        }

        private void dataUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataUsers.CurrentRow == null) return;

            var currentRowLogin = dataUsers.CurrentRow.Cells[0].Value.ToString();
            var user = Query.GetUserByLogin(out var isConnected, currentRowLogin);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                textLogin.Text = currentRowLogin;
                comboMode.SelectedIndex = -1;
                comboMode.Text = user["access_mode"].ToString();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataUsers.CurrentRow == null) return;

            var currentRowLogin = dataUsers.CurrentRow.Cells[0].Value.ToString();
            var isConnected = Query.DeleteUserByLogin(currentRowLogin);
            
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            
            UpdateListUsers();
        }
    }
}