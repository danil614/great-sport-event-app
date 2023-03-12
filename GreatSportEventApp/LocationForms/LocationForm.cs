using System;
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

            var dataTable = Query.GetListCities(out var isConnected);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows) comboCity.Items.Add(row[0]);
        }
        
        /// <summary>
        ///     Обновляет список типов мест.
        /// </summary>
        private void UpdateTypeList()
        {
            comboType.Items.Clear();

            var dataTable = Query.GetListTypes(out var isConnected);

            if (!isConnected) 
            { 
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows) comboType.Items.Add(row[0]);
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
            get => int.TryParse(textCapacity.Text, out var result) ? result : 0;
            set => textCapacity.Text = value.ToString();
        }
        
        public string Description
        {
            set => textDescription.Text = value;
        }

        private bool IsChanging { get; }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bool isConnected;
            
            if (IsChanging)
            {
                isConnected = Query.UpdateLocation(LocationId, textName.Text, comboCity.Text, textAddress.Text,
                    comboType.Text, Capacity, textDescription.Text);
            }
            else
            {
                isConnected = Query.InsertLocation(textName.Text, comboCity.Text, textAddress.Text,
                    comboType.Text, Capacity, textDescription.Text);
            }
            
            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
        }
    }
}