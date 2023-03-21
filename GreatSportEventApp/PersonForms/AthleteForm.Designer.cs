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
            textDescription = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            textPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            label7 = new System.Windows.Forms.Label();
            dateBirth = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            textPatronymic = new System.Windows.Forms.TextBox();
            labelTeam = new System.Windows.Forms.Label();
            textTeamName = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            SelectTeamButton = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            comboGender = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            textSurname = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(8, 5);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(842, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление спортсмена";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(8, 211);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 32);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRating
            // 
            textRating.Dock = System.Windows.Forms.DockStyle.Fill;
            textRating.Location = new System.Drawing.Point(163, 278);
            textRating.Name = "textRating";
            textRating.Size = new System.Drawing.Size(687, 26);
            textRating.TabIndex = 5;
            textRating.Validating += TextRating_Validating;
            // 
            // comboPosition
            // 
            comboPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            comboPosition.FormattingEnabled = true;
            comboPosition.Location = new System.Drawing.Point(163, 214);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new System.Drawing.Size(687, 26);
            comboPosition.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(8, 275);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(149, 32);
            label5.TabIndex = 11;
            label5.Text = "Рейтинг:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(8, 339);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(149, 224);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textDescription
            // 
            textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            textDescription.Location = new System.Drawing.Point(163, 342);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(687, 218);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            textPhoneNumber.Location = new System.Drawing.Point(163, 246);
            textPhoneNumber.Mask = "+7 (999) 999-99-99";
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new System.Drawing.Size(687, 26);
            textPhoneNumber.TabIndex = 27;
            // 
            // label7
            // 
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(8, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 32);
            label7.TabIndex = 26;
            label7.Text = "Дата рождения:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            dateBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateBirth.Location = new System.Drawing.Point(163, 182);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new System.Drawing.Size(687, 26);
            dateBirth.TabIndex = 25;
            dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Location = new System.Drawing.Point(8, 115);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(149, 32);
            label10.TabIndex = 21;
            label10.Text = "Отчество:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPatronymic
            // 
            textPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            textPatronymic.Location = new System.Drawing.Point(163, 118);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new System.Drawing.Size(687, 26);
            textPatronymic.TabIndex = 20;
            textPatronymic.Validating += TextLength_Validating;
            // 
            // labelTeam
            // 
            labelTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTeam.Location = new System.Drawing.Point(8, 307);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new System.Drawing.Size(149, 32);
            labelTeam.TabIndex = 30;
            labelTeam.Text = "Команда:";
            labelTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTeamName
            // 
            textTeamName.Dock = System.Windows.Forms.DockStyle.Fill;
            textTeamName.Location = new System.Drawing.Point(3, 3);
            textTeamName.Name = "textTeamName";
            textTeamName.ReadOnly = true;
            textTeamName.Size = new System.Drawing.Size(513, 26);
            textTeamName.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 9);
            tableLayoutPanel1.Controls.Add(dateBirth, 1, 5);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 8);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(comboPosition, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 11);
            tableLayoutPanel1.Controls.Add(comboGender, 1, 4);
            tableLayoutPanel1.Controls.Add(textPhoneNumber, 1, 7);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(textRating, 1, 8);
            tableLayoutPanel1.Controls.Add(labelTeam, 0, 9);
            tableLayoutPanel1.Controls.Add(label6, 0, 10);
            tableLayoutPanel1.Controls.Add(textDescription, 1, 10);
            tableLayoutPanel1.Controls.Add(textPatronymic, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 3);
            tableLayoutPanel1.Controls.Add(textName, 1, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(textSurname, 1, 1);
            tableLayoutPanel1.Controls.Add(label12, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 20, 20);
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(873, 649);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(textTeamName, 0, 0);
            tableLayoutPanel2.Controls.Add(SelectTeamButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(160, 307);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(693, 32);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // SelectTeamButton
            // 
            SelectTeamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectTeamButton.Location = new System.Drawing.Point(522, 3);
            SelectTeamButton.Name = "SelectTeamButton";
            SelectTeamButton.Size = new System.Drawing.Size(168, 26);
            SelectTeamButton.TabIndex = 31;
            SelectTeamButton.Text = "Выбрать";
            SelectTeamButton.UseVisualStyleBackColor = true;
            SelectTeamButton.Click += SelectTeamButton_Click;
            // 
            // label9
            // 
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Location = new System.Drawing.Point(8, 147);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(149, 32);
            label9.TabIndex = 23;
            label9.Text = "Пол:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(721, 566);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 60);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // comboGender
            // 
            comboGender.Dock = System.Windows.Forms.DockStyle.Fill;
            comboGender.FormattingEnabled = true;
            comboGender.Location = new System.Drawing.Point(163, 150);
            comboGender.Name = "comboGender";
            comboGender.Size = new System.Drawing.Size(687, 26);
            comboGender.TabIndex = 22;
            // 
            // label8
            // 
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(8, 243);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(149, 32);
            label8.TabIndex = 24;
            label8.Text = "Номер телефона:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Dock = System.Windows.Forms.DockStyle.Fill;
            textName.Location = new System.Drawing.Point(163, 86);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(687, 26);
            textName.TabIndex = 19;
            textName.Validating += TextLength_Validating;
            // 
            // label11
            // 
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Location = new System.Drawing.Point(8, 83);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(149, 32);
            label11.TabIndex = 18;
            label11.Text = "Имя:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSurname
            // 
            textSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            textSurname.Location = new System.Drawing.Point(163, 54);
            textSurname.Name = "textSurname";
            textSurname.Size = new System.Drawing.Size(687, 26);
            textSurname.TabIndex = 17;
            textSurname.Validating += TextLength_Validating;
            // 
            // label12
            // 
            label12.Dock = System.Windows.Forms.DockStyle.Fill;
            label12.Location = new System.Drawing.Point(8, 51);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(149, 32);
            label12.TabIndex = 16;
            label12.Text = "Фамилия:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AthleteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(873, 649);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AthleteForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление спортсмена";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.TextBox textTeamName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SelectTeamButton;
        private System.Windows.Forms.Button buttonSave;
    }
}