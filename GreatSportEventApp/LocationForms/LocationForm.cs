using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp.LocationForms
{
    public partial class LocationForm : Form
    {
        public LocationForm(bool isChanging)
        {
            IsChanging = isChanging;

            InitializeComponent();

            // Запрещаем редактирование города и типа места
            comboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateCityList();
            UpdateTypeList();

            if (IsChanging)
            {
                Text = @"Изменение места";
                labelTitle.Text = @"Изменение места";
            }
        }

        /// <summary>
        ///     Обновляет список городов.
        /// </summary>
        private void UpdateCityList()
        {
            comboCity.Items.Clear();

            DataTable dataTable = Query.GetListCities(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                _ = comboCity.Items.Add(row[0]);
            }
        }

        /// <summary>
        ///     Обновляет список типов мест.
        /// </summary>
        private void UpdateTypeList()
        {
            comboType.Items.Clear();

            DataTable dataTable = Query.GetListTypes(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                _ = comboType.Items.Add(row[0]);
            }
        }

        public int LocationId { get; set; }

        public string LocationName
        {
            set => textName.Text = value;
        }

        public string City
        {
            set => comboCity.SelectedItem = value;
        }

        public string Address
        {
            set => textAddress.Text = value;
        }

        public string Type
        {
            set => comboType.Text = value;
        }

        public int Capacity
        {
            get => int.TryParse(textCapacity.Text, out int result) ? result : 0;
            set => textCapacity.Text = value.ToString();
        }

        public string Description
        {
            set => textDescription.Text = value;
        }

        private bool IsChanging { get; }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bool isConnected = IsChanging
                ? Query.UpdateLocation(LocationId, textName.Text, comboCity.Text, textAddress.Text,
                    comboType.Text, Capacity, textDescription.Text)
                : Query.InsertLocation(textName.Text, comboCity.Text, textAddress.Text,
                    comboType.Text, Capacity, textDescription.Text);
            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
        }

        #region Validating

        private void TextCapacity_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetIntError(sender, errorProvider1);
        }

        private void TextLength_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60);
        }

        private void TextDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60000);
        }

        #endregion
    }
}