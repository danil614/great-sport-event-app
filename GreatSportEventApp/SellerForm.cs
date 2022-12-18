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
        /// Обновляет список зрителей.
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
            var addingPerson = new AddingPerson();
            addingPerson.ShowDialog();
            UpdateListViewers();
        }
    }
}