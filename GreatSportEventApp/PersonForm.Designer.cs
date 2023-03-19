using System.ComponentModel;

namespace GreatSportEventApp
{
    partial class PersonForm
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
            label1 = new System.Windows.Forms.Label();
            textSurname = new System.Windows.Forms.TextBox();
            labelTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            textPatronymic = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            comboGender = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dateBirth = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            textPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 26);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSurname
            // 
            textSurname.Location = new System.Drawing.Point(162, 55);
            textSurname.Name = "textSurname";
            textSurname.Size = new System.Drawing.Size(210, 26);
            textSurname.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(265, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление зрителя";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 26);
            label2.TabIndex = 3;
            label2.Text = "Имя:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Location = new System.Drawing.Point(163, 87);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(209, 26);
            textName.TabIndex = 4;
            // 
            // textPatronymic
            // 
            textPatronymic.Location = new System.Drawing.Point(163, 119);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new System.Drawing.Size(209, 26);
            textPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 26);
            label3.TabIndex = 6;
            label3.Text = "Отчество:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Location = new System.Drawing.Point(163, 151);
            comboGender.Name = "comboGender";
            comboGender.Size = new System.Drawing.Size(169, 26);
            comboGender.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(12, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 26);
            label4.TabIndex = 9;
            label4.Text = "Пол:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(12, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 26);
            label5.TabIndex = 11;
            label5.Text = "Номер телефона:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateBirth.Location = new System.Drawing.Point(162, 215);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new System.Drawing.Size(170, 26);
            dateBirth.TabIndex = 12;
            dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(12, 215);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(145, 26);
            label6.TabIndex = 13;
            label6.Text = "Дата рождения:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(243, 262);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new System.Drawing.Point(163, 183);
            textPhoneNumber.Mask = "+7 (999) 999-99-99";
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new System.Drawing.Size(169, 26);
            textPhoneNumber.TabIndex = 15;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(397, 315);
            Controls.Add(textPhoneNumber);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(dateBirth);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboGender);
            Controls.Add(label3);
            Controls.Add(textPatronymic);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(textSurname);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление зрителя";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MaskedTextBox textPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelTitle;

        #endregion
    }
}