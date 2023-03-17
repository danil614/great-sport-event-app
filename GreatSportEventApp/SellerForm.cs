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
            System.Data.DataTable listViewers = Query.GetListViewers(out bool isConnected);
            System.Data.DataTable listTickets = Query.GetListTickets(out bool isConnectedTickets);

            if (!isConnected || !isConnectedTickets)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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
            PersonForm personForm = new(false);
            _ = personForm.ShowDialog();
            UpdateListViewers();
        }

        private void buttonChangeViewer_Click(object sender, EventArgs e)
        {
            if (dataViewers.CurrentRow == null)
            {
                return;
            }

            int currentRowId = (int)dataViewers.CurrentRow.Cells[0].Value;
            System.Data.DataRow person = Query.GetViewerById(out bool isConnected, currentRowId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                PersonForm personForm = new(true)
                {
                    PersonId = currentRowId,
                    Surname = person["surname"].ToString(),
                    PersonName = person["name"].ToString(),
                    Patronymic = person["patronymic"].ToString(),
                    Gender = person["gender_name"].ToString(),
                    PhoneNumber = person["phone_number"].ToString(),
                    BirthDate = (DateTime)person["birth_date"]
                };
                _ = personForm.ShowDialog();
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
            if (dataViewers.CurrentRow == null)
            {
                return;
            }

            int currentRowId = (int)dataViewers.CurrentRow.Cells[0].Value;
            _ = decimal.TryParse(textPrice.Text, out decimal price);
            bool isConnected = Query.InsertTicket(currentRowId, textSeat.Text, price);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }

            textPrice.Text = "";
            textSeat.Text = "";

            UpdateListViewers();
        }
    }
}