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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            SelectSeatButton = new System.Windows.Forms.Button();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            textSportEventName = new System.Windows.Forms.TextBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "Зритель:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(677, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление билета";
            // 
            // textViewerName
            // 
            textViewerName.Dock = System.Windows.Forms.DockStyle.Fill;
            textViewerName.Location = new System.Drawing.Point(3, 3);
            textViewerName.Name = "textViewerName";
            textViewerName.ReadOnly = true;
            textViewerName.Size = new System.Drawing.Size(382, 26);
            textViewerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 32);
            label3.TabIndex = 6;
            label3.Text = "Дата продажи:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 32);
            label4.TabIndex = 9;
            label4.Text = "Продавец:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 206);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(159, 32);
            label6.TabIndex = 13;
            label6.Text = "Цена:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(473, 248);
            buttonSave.Margin = new System.Windows.Forms.Padding(10);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new System.Windows.Forms.Padding(10);
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // SelectViewerButton
            // 
            SelectViewerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectViewerButton.Location = new System.Drawing.Point(391, 3);
            SelectViewerButton.Name = "SelectViewerButton";
            SelectViewerButton.Size = new System.Drawing.Size(124, 26);
            SelectViewerButton.TabIndex = 17;
            SelectViewerButton.Text = "Выбрать";
            SelectViewerButton.UseVisualStyleBackColor = true;
            SelectViewerButton.Click += SelectViewerButton_Click;
            // 
            // textEmployeeName
            // 
            textEmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            textEmployeeName.Location = new System.Drawing.Point(168, 49);
            textEmployeeName.Name = "textEmployeeName";
            textEmployeeName.ReadOnly = true;
            textEmployeeName.Size = new System.Drawing.Size(512, 26);
            textEmployeeName.TabIndex = 18;
            // 
            // textPrice
            // 
            textPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textPrice.Location = new System.Drawing.Point(168, 209);
            textPrice.Name = "textPrice";
            textPrice.ReadOnly = true;
            textPrice.Size = new System.Drawing.Size(152, 26);
            textPrice.TabIndex = 19;
            textPrice.Validating += TextPrice_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 174);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 32);
            label2.TabIndex = 20;
            label2.Text = "Место:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSeat
            // 
            textSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            textSeat.Location = new System.Drawing.Point(3, 3);
            textSeat.Name = "textSeat";
            textSeat.ReadOnly = true;
            textSeat.Size = new System.Drawing.Size(382, 26);
            textSeat.TabIndex = 21;
            textSeat.Validating += TextSeat_Validating;
            // 
            // saleDateTime
            // 
            saleDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            saleDateTime.Enabled = false;
            saleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            saleDateTime.Location = new System.Drawing.Point(168, 145);
            saleDateTime.Name = "saleDateTime";
            saleDateTime.Size = new System.Drawing.Size(206, 26);
            saleDateTime.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 7);
            tableLayoutPanel1.Controls.Add(textPrice, 1, 6);
            tableLayoutPanel1.Controls.Add(saleDateTime, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(textEmployeeName, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(textSportEventName, 1, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(703, 313);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(SelectSeatButton, 1, 0);
            tableLayoutPanel3.Controls.Add(textSeat, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(165, 174);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel3.Size = new System.Drawing.Size(518, 32);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // SelectSeatButton
            // 
            SelectSeatButton.Location = new System.Drawing.Point(391, 3);
            SelectSeatButton.Name = "SelectSeatButton";
            SelectSeatButton.Size = new System.Drawing.Size(122, 26);
            SelectSeatButton.TabIndex = 27;
            SelectSeatButton.Text = "Выбрать";
            SelectSeatButton.UseVisualStyleBackColor = true;
            SelectSeatButton.Click += SelectSeatButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(SelectViewerButton, 1, 0);
            tableLayoutPanel2.Controls.Add(textViewerName, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(165, 78);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(518, 32);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 110);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 32);
            label5.TabIndex = 25;
            label5.Text = "Мероприятие:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSportEventName
            // 
            textSportEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            textSportEventName.Location = new System.Drawing.Point(168, 113);
            textSportEventName.Name = "textSportEventName";
            textSportEventName.ReadOnly = true;
            textSportEventName.Size = new System.Drawing.Size(512, 26);
            textSportEventName.TabIndex = 26;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(713, 323);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicketForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление билета";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSportEventName;
        private System.Windows.Forms.Button SelectSeatButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}