using System.ComponentModel;

namespace GreatSportEventApp.PersonForms
{
    partial class ViewerForm
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSurname
            // 
            textSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            textSurname.Location = new System.Drawing.Point(154, 49);
            textSurname.Name = "textSurname";
            textSurname.Size = new System.Drawing.Size(337, 26);
            textSurname.TabIndex = 1;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(488, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление зрителя";
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 32);
            label2.TabIndex = 3;
            label2.Text = "Имя:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Dock = System.Windows.Forms.DockStyle.Fill;
            textName.Location = new System.Drawing.Point(154, 81);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(337, 26);
            textName.TabIndex = 4;
            // 
            // textPatronymic
            // 
            textPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            textPatronymic.Location = new System.Drawing.Point(154, 113);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new System.Drawing.Size(337, 26);
            textPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 32);
            label3.TabIndex = 6;
            label3.Text = "Отчество:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGender
            // 
            comboGender.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            comboGender.FormattingEnabled = true;
            comboGender.Location = new System.Drawing.Point(154, 145);
            comboGender.Name = "comboGender";
            comboGender.Size = new System.Drawing.Size(185, 26);
            comboGender.TabIndex = 8;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(145, 32);
            label4.TabIndex = 9;
            label4.Text = "Пол:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 174);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 32);
            label5.TabIndex = 11;
            label5.Text = "Номер телефона:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBirth
            // 
            dateBirth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateBirth.Location = new System.Drawing.Point(154, 209);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new System.Drawing.Size(146, 26);
            dateBirth.TabIndex = 12;
            dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 206);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(145, 32);
            label6.TabIndex = 13;
            label6.Text = "Дата рождения:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(291, 241);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textPhoneNumber.Location = new System.Drawing.Point(154, 177);
            textPhoneNumber.Mask = "+7 (999) 999-99-99";
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new System.Drawing.Size(185, 26);
            textPhoneNumber.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 7);
            tableLayoutPanel1.Controls.Add(textPhoneNumber, 1, 5);
            tableLayoutPanel1.Controls.Add(dateBirth, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textSurname, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textName, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(comboGender, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(textPatronymic, 1, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(514, 305);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // ViewerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(524, 315);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewerForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление зрителя";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}