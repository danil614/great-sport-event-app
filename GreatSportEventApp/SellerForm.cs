using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class SellerForm : Form
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

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataViewers.DataSource = listViewers;
            }

            // Растягиваем колонки
            dataViewers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                personForm.IdPerson = (int)person["viewer_id"];
                personForm.Surname = (string)person["surname"];
                personForm.NamePerson = (string)person["name"];
                personForm.Patronymic = (string)person["patronymic"];
                personForm.Gender = (string)person["gender_name"];
                personForm.PhoneNumber = (string)person["phone_number"];
                personForm.BirthDate = (DateTime)person["birth_date"];
                personForm.ShowDialog();
                UpdateListViewers();
            }
        }

        private void dataViewers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonChangeViewer_Click(sender, e);
        }
    }
}