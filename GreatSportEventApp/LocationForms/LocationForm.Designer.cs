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
            label1 = new System.Windows.Forms.Label();
            textAddress = new System.Windows.Forms.TextBox();
            labelTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            textCapacity = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            comboCity = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            comboType = new System.Windows.Forms.ComboBox();
            textDescription = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 26);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textAddress
            // 
            textAddress.Location = new System.Drawing.Point(150, 120);
            textAddress.Name = "textAddress";
            textAddress.Size = new System.Drawing.Size(418, 26);
            textAddress.TabIndex = 3;
            textAddress.Validating += TextLength_Validating;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(265, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление места";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 26);
            label2.TabIndex = 3;
            label2.Text = "Город:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textName
            // 
            textName.Location = new System.Drawing.Point(150, 55);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(418, 26);
            textName.TabIndex = 1;
            textName.Validating += TextLength_Validating;
            // 
            // textCapacity
            // 
            textCapacity.Location = new System.Drawing.Point(150, 184);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new System.Drawing.Size(127, 26);
            textCapacity.TabIndex = 5;
            textCapacity.Validating += TextCapacity_Validating;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 26);
            label3.TabIndex = 6;
            label3.Text = "Адрес:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCity
            // 
            comboCity.FormattingEnabled = true;
            comboCity.Location = new System.Drawing.Point(150, 87);
            comboCity.Name = "comboCity";
            comboCity.Size = new System.Drawing.Size(286, 26);
            comboCity.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(12, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 26);
            label4.TabIndex = 9;
            label4.Text = "Тип места:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(12, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 26);
            label5.TabIndex = 11;
            label5.Text = "Вместимость:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(12, 216);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 26);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(439, 451);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new System.Drawing.Point(150, 152);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(286, 26);
            comboType.TabIndex = 4;
            // 
            // textDescription
            // 
            textDescription.Location = new System.Drawing.Point(150, 216);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(418, 219);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LocationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(597, 509);
            Controls.Add(textDescription);
            Controls.Add(comboType);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboCity);
            Controls.Add(label3);
            Controls.Add(textCapacity);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(textAddress);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LocationForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление места";
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelTitle;

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}