using System.ComponentModel;

namespace GreatSportEventApp.PersonForms
{
    partial class AthleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            labelTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textRating = new System.Windows.Forms.TextBox();
            comboPosition = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            textDescription = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            textPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            label7 = new System.Windows.Forms.Label();
            dateBirth = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            comboGender = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            textPatronymic = new System.Windows.Forms.TextBox();
            textName = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            textSurname = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            SelectTeamButton = new System.Windows.Forms.Button();
            labelTeam = new System.Windows.Forms.Label();
            textTeamName = new System.Windows.Forms.TextBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(350, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление спортсмена";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(13, 247);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 26);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRating
            // 
            textRating.Location = new System.Drawing.Point(166, 279);
            textRating.Name = "textRating";
            textRating.Size = new System.Drawing.Size(146, 26);
            textRating.TabIndex = 5;
            textRating.Validating += TextRating_Validating;
            // 
            // comboPosition
            // 
            comboPosition.FormattingEnabled = true;
            comboPosition.Location = new System.Drawing.Point(166, 247);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new System.Drawing.Size(255, 26);
            comboPosition.TabIndex = 2;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(13, 279);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 26);
            label5.TabIndex = 11;
            label5.Text = "Рейтинг:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(12, 343);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 26);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(474, 582);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textDescription
            // 
            textDescription.Location = new System.Drawing.Point(166, 343);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(437, 219);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new System.Drawing.Point(167, 183);
            textPhoneNumber.Mask = "+7 (999) 999-99-99";
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new System.Drawing.Size(213, 26);
            textPhoneNumber.TabIndex = 27;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(12, 215);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 26);
            label7.TabIndex = 26;
            label7.Text = "Дата рождения:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateBirth.Location = new System.Drawing.Point(166, 215);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new System.Drawing.Size(147, 26);
            dateBirth.TabIndex = 25;
            dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(12, 183);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(149, 26);
            label8.TabIndex = 24;
            label8.Text = "Номер телефона:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(12, 151);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(132, 26);
            label9.TabIndex = 23;
            label9.Text = "Пол:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Location = new System.Drawing.Point(166, 151);
            comboGender.Name = "comboGender";
            comboGender.Size = new System.Drawing.Size(146, 26);
            comboGender.TabIndex = 22;
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(12, 119);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(132, 26);
            label10.TabIndex = 21;
            label10.Text = "Отчество:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPatronymic
            // 
            textPatronymic.Location = new System.Drawing.Point(166, 119);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new System.Drawing.Size(255, 26);
            textPatronymic.TabIndex = 20;
            textPatronymic.Validating += TextLength_Validating;
            // 
            // textName
            // 
            textName.Location = new System.Drawing.Point(166, 87);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(255, 26);
            textName.TabIndex = 19;
            textName.Validating += TextLength_Validating;
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(12, 87);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(132, 26);
            label11.TabIndex = 18;
            label11.Text = "Имя:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSurname
            // 
            textSurname.Location = new System.Drawing.Point(166, 55);
            textSurname.Name = "textSurname";
            textSurname.Size = new System.Drawing.Size(255, 26);
            textSurname.TabIndex = 17;
            textSurname.Validating += TextLength_Validating;
            // 
            // label12
            // 
            label12.Location = new System.Drawing.Point(12, 55);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(132, 26);
            label12.TabIndex = 16;
            label12.Text = "Фамилия:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectTeamButton
            // 
            SelectTeamButton.Location = new System.Drawing.Point(500, 311);
            SelectTeamButton.Name = "SelectTeamButton";
            SelectTeamButton.Size = new System.Drawing.Size(103, 26);
            SelectTeamButton.TabIndex = 31;
            SelectTeamButton.Text = "Выбрать";
            SelectTeamButton.UseVisualStyleBackColor = true;
            SelectTeamButton.Click += SelectTeamButton_Click;
            // 
            // labelTeam
            // 
            labelTeam.Location = new System.Drawing.Point(12, 310);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new System.Drawing.Size(132, 26);
            labelTeam.TabIndex = 30;
            labelTeam.Text = "Команда:";
            labelTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTeamName
            // 
            textTeamName.Location = new System.Drawing.Point(166, 311);
            textTeamName.Name = "textTeamName";
            textTeamName.ReadOnly = true;
            textTeamName.Size = new System.Drawing.Size(328, 26);
            textTeamName.TabIndex = 29;
            // 
            // AthleteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 639);
            Controls.Add(SelectTeamButton);
            Controls.Add(labelTeam);
            Controls.Add(textTeamName);
            Controls.Add(textPhoneNumber);
            Controls.Add(label7);
            Controls.Add(dateBirth);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(comboGender);
            Controls.Add(label10);
            Controls.Add(textPatronymic);
            Controls.Add(textName);
            Controls.Add(label11);
            Controls.Add(textSurname);
            Controls.Add(label12);
            Controls.Add(textDescription);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboPosition);
            Controls.Add(textRating);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AthleteForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление спортсмена";
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPosition;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitle;

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox textPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SelectTeamButton;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.TextBox textTeamName;
    }
}