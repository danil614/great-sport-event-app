using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp
{
    public partial class SellerForm : DockContent
    {
        public SellerForm()
        {
            InitializeComponent();
            UpdateListViewers();
        }

        /// <summary>
        ///     Обновляет список зрителей.
        /// </summary>
        private void UpdateListViewers()
        {
            // Получаем запрос со зрителями
            var listViewers = Query.GetListViewers(out var isConnected);
            var listTickets = Query.GetListTickets(out var isConnectedTickets);

            if (!isConnected || !isConnectedTickets)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataViewers.DataSource = listViewers;
                dataTickets.DataSource = listTickets;
            }

            // Растягиваем колонки
            dataViewers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonAddViewer_Click(object sender, EventArgs e)
        {
            var personForm = new PersonForm(false);
            personForm.ShowDialog();
            UpdateListViewers();
        }

        private void buttonChangeViewer_Click(object sender, EventArgs e)
        {
            if (dataViewers.CurrentRow == null) return;

            var currentRowId = (int)dataViewers.CurrentRow.Cells[0].Value;
            var person = Query.GetViewerById(out var isConnected, currentRowId);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                var personForm = new PersonForm(true);
                personForm.PersonId = currentRowId;
                personForm.Surname = person["surname"].ToString();
                personForm.PersonName = person["name"].ToString();
                personForm.Patronymic = person["patronymic"].ToString();
                personForm.Gender = person["gender_name"].ToString();
                personForm.PhoneNumber = person["phone_number"].ToString();
                personForm.BirthDate = (DateTime)person["birth_date"];
                personForm.ShowDialog();
                UpdateListViewers();
            }
        }

        private void dataViewers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonChangeViewer_Click(sender, e);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            if (dataViewers.CurrentRow == null) return;
            var currentRowId = (int)dataViewers.CurrentRow.Cells[0].Value;
            decimal.TryParse(textPrice.Text, out var price);
            var isConnected = Query.InsertTicket(currentRowId, textSeat.Text, price);
            
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }

            textPrice.Text = "";
            textSeat.Text = "";
            
            UpdateListViewers();
        }
    }
}