using System.ComponentModel;

namespace GreatSportEventApp.TicketForms
{
    partial class TicketForm
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
            labelTitle = new System.Windows.Forms.Label();
            textViewerName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            SelectViewerButton = new System.Windows.Forms.Button();
            textEmployeeName = new System.Windows.Forms.TextBox();
            textPrice = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label2 = new System.Windows.Forms.Label();
            textSeat = new System.Windows.Forms.TextBox();
            saleDateTime = new System.Windows.Forms.DateTimePicker();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 26);
            label1.TabIndex = 0;
            label1.Text = "Зритель:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(457, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление билета";
            // 
            // textViewerName
            // 
            textViewerName.Location = new System.Drawing.Point(177, 88);
            textViewerName.Name = "textViewerName";
            textViewerName.ReadOnly = true;
            textViewerName.Size = new System.Drawing.Size(342, 26);
            textViewerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 26);
            label3.TabIndex = 6;
            label3.Text = "Дата продажи:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(12, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 26);
            label4.TabIndex = 9;
            label4.Text = "Продавец:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(13, 183);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 26);
            label6.TabIndex = 13;
            label6.Text = "Цена:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(496, 224);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // SelectViewerButton
            // 
            SelectViewerButton.Location = new System.Drawing.Point(525, 88);
            SelectViewerButton.Name = "SelectViewerButton";
            SelectViewerButton.Size = new System.Drawing.Size(100, 26);
            SelectViewerButton.TabIndex = 17;
            SelectViewerButton.Text = "Выбрать";
            SelectViewerButton.UseVisualStyleBackColor = true;
            SelectViewerButton.Click += SelectViewerButton_Click;
            // 
            // textEmployeeName
            // 
            textEmployeeName.Location = new System.Drawing.Point(177, 55);
            textEmployeeName.Name = "textEmployeeName";
            textEmployeeName.ReadOnly = true;
            textEmployeeName.Size = new System.Drawing.Size(448, 26);
            textEmployeeName.TabIndex = 18;
            // 
            // textPrice
            // 
            textPrice.Location = new System.Drawing.Point(177, 183);
            textPrice.Name = "textPrice";
            textPrice.Size = new System.Drawing.Size(139, 26);
            textPrice.TabIndex = 19;
            textPrice.Validating += TextPrice_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(13, 151);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 26);
            label2.TabIndex = 20;
            label2.Text = "Место:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSeat
            // 
            textSeat.Location = new System.Drawing.Point(177, 151);
            textSeat.Name = "textSeat";
            textSeat.Size = new System.Drawing.Size(139, 26);
            textSeat.TabIndex = 21;
            textSeat.Validating += TextSeat_Validating;
            // 
            // saleDateTime
            // 
            saleDateTime.Enabled = false;
            saleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            saleDateTime.Location = new System.Drawing.Point(177, 119);
            saleDateTime.Name = "saleDateTime";
            saleDateTime.Size = new System.Drawing.Size(200, 26);
            saleDateTime.TabIndex = 22;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(643, 282);
            Controls.Add(saleDateTime);
            Controls.Add(textSeat);
            Controls.Add(label2);
            Controls.Add(textPrice);
            Controls.Add(textEmployeeName);
            Controls.Add(SelectViewerButton);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textViewerName);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicketForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление билета";
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textViewerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion
        private System.Windows.Forms.Button SelectViewerButton;
        private System.Windows.Forms.TextBox textEmployeeName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textSeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker saleDateTime;
    }
}