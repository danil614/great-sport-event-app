using System.ComponentModel;

namespace GreatSportEventApp.PersonForms
{
    partial class EmployeeForm
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
            textTeamName = new System.Windows.Forms.TextBox();
            comboPosition = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            textPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            label7 = new System.Windows.Forms.Label();
            dateBirth = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            comboGender = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            textPatronymic = new System.Windows.Forms.TextBox();
            textSurname = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            SelectTeamButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            buttonSave = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            tableLayoutPanel2.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(645, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление спортсмена";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 238);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 32);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTeamName
            // 
            textTeamName.Dock = System.Windows.Forms.DockStyle.Fill;
            textTeamName.Location = new System.Drawing.Point(3, 3);
            textTeamName.Name = "textTeamName";
            textTeamName.ReadOnly = true;
            textTeamName.Size = new System.Drawing.Size(361, 26);
            textTeamName.TabIndex = 5;
            // 
            // comboPosition
            // 
            comboPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            comboPosition.FormattingEnabled = true;
            comboPosition.Location = new System.Drawing.Point(158, 241);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new System.Drawing.Size(490, 26);
            comboPosition.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 270);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(149, 38);
            label5.TabIndex = 11;
            label5.Text = "Команда:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textPhoneNumber.Location = new System.Drawing.Point(158, 177);
            textPhoneNumber.Mask = "+7 (999) 999-99-99";
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new System.Drawing.Size(194, 26);
            textPhoneNumber.TabIndex = 27;
            // 
            // label7
            // 
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(3, 206);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 32);
            label7.TabIndex = 26;
            label7.Text = "Дата рождения:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            dateBirth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateBirth.Location = new System.Drawing.Point(158, 209);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new System.Drawing.Size(147, 26);
            dateBirth.TabIndex = 25;
            dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(3, 174);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(149, 32);
            label8.TabIndex = 24;
            label8.Text = "Номер телефона:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Location = new System.Drawing.Point(3, 142);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(149, 32);
            label9.TabIndex = 23;
            label9.Text = "Пол:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGender
            // 
            comboGender.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            comboGender.FormattingEnabled = true;
            comboGender.Location = new System.Drawing.Point(158, 145);
            comboGender.Name = "comboGender";
            comboGender.Size = new System.Drawing.Size(194, 26);
            comboGender.TabIndex = 22;
            // 
            // label10
            // 
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Location = new System.Drawing.Point(3, 110);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(149, 32);
            label10.TabIndex = 21;
            label10.Text = "Отчество:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPatronymic
            // 
            textPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            textPatronymic.Location = new System.Drawing.Point(158, 113);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new System.Drawing.Size(490, 26);
            textPatronymic.TabIndex = 20;
            textPatronymic.Validating += TextLength_Validating;
            // 
            // textSurname
            // 
            textSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            textSurname.Location = new System.Drawing.Point(158, 49);
            textSurname.Name = "textSurname";
            textSurname.Size = new System.Drawing.Size(490, 26);
            textSurname.TabIndex = 19;
            textSurname.Validating += TextLength_Validating;
            // 
            // label11
            // 
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Location = new System.Drawing.Point(3, 78);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(149, 32);
            label11.TabIndex = 18;
            label11.Text = "Имя:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectTeamButton
            // 
            SelectTeamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectTeamButton.Location = new System.Drawing.Point(370, 3);
            SelectTeamButton.Name = "SelectTeamButton";
            SelectTeamButton.Size = new System.Drawing.Size(117, 26);
            SelectTeamButton.TabIndex = 28;
            SelectTeamButton.Text = "Выбрать";
            SelectTeamButton.UseVisualStyleBackColor = true;
            SelectTeamButton.Click += SelectTeamButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textTeamName, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectTeamButton, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(158, 273);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(490, 32);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(buttonSave, 1, 9);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 8);
            tableLayoutPanel2.Controls.Add(dateBirth, 1, 6);
            tableLayoutPanel2.Controls.Add(label5, 0, 8);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(comboPosition, 1, 7);
            tableLayoutPanel2.Controls.Add(textPhoneNumber, 1, 5);
            tableLayoutPanel2.Controls.Add(label2, 0, 7);
            tableLayoutPanel2.Controls.Add(textPatronymic, 1, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 5);
            tableLayoutPanel2.Controls.Add(label10, 0, 3);
            tableLayoutPanel2.Controls.Add(comboGender, 1, 4);
            tableLayoutPanel2.Controls.Add(label9, 0, 4);
            tableLayoutPanel2.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(textSurname, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label11, 0, 2);
            tableLayoutPanel2.Controls.Add(textName, 1, 2);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(651, 372);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(448, 311);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 32);
            label1.TabIndex = 30;
            label1.Text = "Фамилия:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Dock = System.Windows.Forms.DockStyle.Fill;
            textName.Location = new System.Drawing.Point(158, 81);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(490, 26);
            textName.TabIndex = 31;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(676, 382);
            Controls.Add(tableLayoutPanel2);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeForm";
            Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление сотрудника";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPosition;
        private System.Windows.Forms.TextBox textTeamName;
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
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SelectTeamButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
    }
}