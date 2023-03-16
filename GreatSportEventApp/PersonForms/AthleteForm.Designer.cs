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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRating = new System.Windows.Forms.TextBox();
            this.comboPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 46);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Добавление спортсмена";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(166, 279);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(146, 30);
            this.textRating.TabIndex = 5;
            this.textRating.Validating += new System.ComponentModel.CancelEventHandler(this.TextRating_Validating);
            // 
            // comboPosition
            // 
            this.comboPosition.FormattingEnabled = true;
            this.comboPosition.Location = new System.Drawing.Point(166, 247);
            this.comboPosition.Name = "comboPosition";
            this.comboPosition.Size = new System.Drawing.Size(255, 31);
            this.comboPosition.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Рейтинг:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Описание:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(450, 550);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 37);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(166, 311);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDescription.Size = new System.Drawing.Size(413, 219);
            this.textDescription.TabIndex = 6;
            this.textDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TextDescription_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(167, 183);
            this.textPhoneNumber.Mask = "+7 (999) 999-99-99";
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(213, 30);
            this.textPhoneNumber.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата рождения:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(166, 215);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(147, 30);
            this.dateBirth.TabIndex = 25;
            this.dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Номер телефона:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Пол:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(166, 151);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(146, 31);
            this.comboGender.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Отчество:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(166, 119);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(255, 30);
            this.textPatronymic.TabIndex = 20;
            this.textPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.TextLength_Validating);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(166, 87);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(255, 30);
            this.textName.TabIndex = 19;
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.TextLength_Validating);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Имя:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(166, 55);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(255, 30);
            this.textSurname.TabIndex = 17;
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.TextLength_Validating);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Фамилия:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AthleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 603);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPatronymic);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboPosition);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AthleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление спортсмена";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}