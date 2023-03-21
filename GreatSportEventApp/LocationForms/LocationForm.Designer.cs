using System.ComponentModel;

namespace GreatSportEventApp.LocationForms
{
    partial class LocationForm
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
            textAddress = new System.Windows.Forms.TextBox();
            labelTitle = new System.Windows.Forms.Label();
            textCapacity = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            comboType = new System.Windows.Forms.ComboBox();
            textDescription = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            comboCity = new System.Windows.Forms.ComboBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textAddress
            // 
            textAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            textAddress.Location = new System.Drawing.Point(154, 118);
            textAddress.Name = "textAddress";
            textAddress.Size = new System.Drawing.Size(627, 26);
            textAddress.TabIndex = 3;
            textAddress.Validating += TextLength_Validating;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(8, 5);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(773, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление места";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCapacity
            // 
            textCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            textCapacity.Location = new System.Drawing.Point(154, 182);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new System.Drawing.Size(627, 26);
            textCapacity.TabIndex = 5;
            textCapacity.Validating += TextCapacity_Validating;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(8, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 32);
            label3.TabIndex = 6;
            label3.Text = "Адрес:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(8, 147);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 32);
            label4.TabIndex = 9;
            label4.Text = "Тип места:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(8, 179);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(140, 32);
            label5.TabIndex = 11;
            label5.Text = "Вместимость:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(8, 211);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(140, 225);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(652, 439);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 62);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // comboType
            // 
            comboType.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType.FormattingEnabled = true;
            comboType.Location = new System.Drawing.Point(154, 150);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(627, 26);
            comboType.TabIndex = 4;
            // 
            // textDescription
            // 
            textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            textDescription.Location = new System.Drawing.Point(154, 214);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(627, 219);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textDescription, 1, 6);
            tableLayoutPanel1.Controls.Add(textName, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(comboCity, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(textCapacity, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(textAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(comboType, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 7);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 20, 20);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(804, 524);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(8, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Dock = System.Windows.Forms.DockStyle.Fill;
            textName.Location = new System.Drawing.Point(154, 54);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(627, 26);
            textName.TabIndex = 1;
            textName.Validating += TextLength_Validating;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(8, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 32);
            label2.TabIndex = 3;
            label2.Text = "Город:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCity
            // 
            comboCity.Dock = System.Windows.Forms.DockStyle.Fill;
            comboCity.FormattingEnabled = true;
            comboCity.Location = new System.Drawing.Point(154, 86);
            comboCity.Name = "comboCity";
            comboCity.Size = new System.Drawing.Size(627, 26);
            comboCity.TabIndex = 2;
            // 
            // LocationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(804, 524);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LocationForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление места";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelTitle;

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCity;
    }
}