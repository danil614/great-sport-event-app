﻿using System;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class PersonForm : Form
    {
        public PersonForm(bool isChanging)
        {
            IsChanging = isChanging;

            InitializeComponent();

            // Запрещаем редактирование пола
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateGenderList();

            if (IsChanging)
            {
                base.Text = @"Изменение зрителя | Спортивное мероприятие";
                labelTitle.Text = @"Изменение зрителя";
            }
        }
        
        public int PersonId { get; set; }

        public string Surname
        {
            set => textSurname.Text = value;
        }

        public string PersonName
        {
            set => textName.Text = value;
        }

        public string Patronymic
        {
            set => textPatronymic.Text = value;
        }

        public string Gender
        {
            set => comboGender.SelectedItem = value;
        }

        public string PhoneNumber
        {
            set => textPhoneNumber.Text = value;
        }

        public DateTime BirthDate
        {
            set => dateBirth.Value = value;
        }

        private bool IsChanging { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var birthDateString = dateBirth.Value.Year + "-" + dateBirth.Value.Month + "-" + dateBirth.Value.Day;

            bool isConnected;
            
            if (IsChanging)
            {
                isConnected = Query.UpdateViewer(PersonId, textSurname.Text, textName.Text,
                    textPatronymic.Text, comboGender.Text, textPhoneNumber.Text, birthDateString);
            }
            else
            {
                isConnected = Query.InsertViewer(textSurname.Text, textName.Text,
                    textPatronymic.Text, comboGender.Text, textPhoneNumber.Text, birthDateString);
            }
            
            if (!isConnected) MessageBox.Show(@"Отсутствует подключение!");

            Close();
        }

        /// <summary>
        ///     Обновляет список полов.
        /// </summary>
        private void UpdateGenderList()
        {
            comboGender.Items.Clear();

            var dataTable = Query.GetListGender(out var isConnected);

            if (!isConnected) MessageBox.Show(@"Отсутствует подключение!");

            foreach (DataRow row in dataTable.Rows) comboGender.Items.Add(row[0]);
        }
    }
}