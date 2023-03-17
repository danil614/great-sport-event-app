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
            System.Data.DataTable listUsers = Query.GetListUsers(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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
            bool isConnected = Query.InsertUser(textLogin.Text, textPassword.Text, comboMode.Text);
            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }
            UpdateListUsers();
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            bool isConnected = Query.UpdateUser(textLogin.Text, textPassword.Text, comboMode.Text);
            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }
            UpdateListUsers();
        }

        private void dataUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataUsers.CurrentRow == null)
            {
                return;
            }

            string currentRowLogin = dataUsers.CurrentRow.Cells[0].Value.ToString();
            System.Data.DataRow user = Query.GetUserByLogin(out bool isConnected, currentRowLogin);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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
            if (dataUsers.CurrentRow == null)
            {
                return;
            }

            string currentRowLogin = dataUsers.CurrentRow.Cells[0].Value.ToString();
            bool isConnected = Query.DeleteUserByLogin(currentRowLogin);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }

            UpdateListUsers();
        }
    }
}