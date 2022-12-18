using System;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class AddingPerson : Form
    {
        public AddingPerson()
        {
            InitializeComponent();
            
            // Запрещаем редактирование пола
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateGenderList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var birthDateString = dateBirth.Value.Year + "-" + dateBirth.Value.Month + "-" + dateBirth.Value.Day;

            var isConnected = Query.InsertViewer(textSurname.Text, textName.Text,
                textPatronymic.Text, comboGender.Text, textPhoneNumber.Text, birthDateString);
            
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            
            Close();
        }

        /// <summary>
        /// Обновляет список полов.
        /// </summary>
        private void UpdateGenderList()
        {
            comboGender.Items.Clear();

            var dataTable = Query.GetListGender(out var isConnected);
            
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }

            foreach (DataRow row in dataTable.Rows)
            {
                comboGender.Items.Add(row[0]);
            }
        }
    }
}