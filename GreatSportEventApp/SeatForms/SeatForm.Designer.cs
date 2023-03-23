using System.ComponentModel;

namespace GreatSportEventApp.SeatForms
{
    partial class SeatForm
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
            textSportEventName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            SelectSportEventButton = new System.Windows.Forms.Button();
            textSeatName = new System.Windows.Forms.TextBox();
            textPrice = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            checkBoxIsOccupied = new System.Windows.Forms.CheckBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            label1.Text = "Мероприятие:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(681, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление посадочного места";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSportEventName
            // 
            textSportEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            textSportEventName.Location = new System.Drawing.Point(3, 3);
            textSportEventName.Name = "textSportEventName";
            textSportEventName.ReadOnly = true;
            textSportEventName.Size = new System.Drawing.Size(385, 26);
            textSportEventName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 32);
            label3.TabIndex = 6;
            label3.Text = "Занято:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 32);
            label4.TabIndex = 9;
            label4.Text = "Место:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(477, 184);
            buttonSave.Margin = new System.Windows.Forms.Padding(10);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new System.Windows.Forms.Padding(10);
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // SelectSportEventButton
            // 
            SelectSportEventButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectSportEventButton.Location = new System.Drawing.Point(394, 3);
            SelectSportEventButton.Name = "SelectSportEventButton";
            SelectSportEventButton.Size = new System.Drawing.Size(125, 26);
            SelectSportEventButton.TabIndex = 17;
            SelectSportEventButton.Text = "Выбрать";
            SelectSportEventButton.UseVisualStyleBackColor = true;
            SelectSportEventButton.Click += SelectSportEventButton_Click;
            // 
            // textSeatName
            // 
            textSeatName.Dock = System.Windows.Forms.DockStyle.Fill;
            textSeatName.Location = new System.Drawing.Point(168, 49);
            textSeatName.Name = "textSeatName";
            textSeatName.Size = new System.Drawing.Size(516, 26);
            textSeatName.TabIndex = 18;
            textSeatName.Validating += TextSeat_Validating;
            // 
            // textPrice
            // 
            textPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textPrice.Location = new System.Drawing.Point(168, 113);
            textPrice.Name = "textPrice";
            textPrice.Size = new System.Drawing.Size(152, 26);
            textPrice.TabIndex = 19;
            textPrice.Validating += TextPrice_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 5);
            tableLayoutPanel1.Controls.Add(textSeatName, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(textPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBoxIsOccupied, 1, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(707, 245);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(SelectSportEventButton, 1, 0);
            tableLayoutPanel2.Controls.Add(textSportEventName, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(165, 78);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(522, 32);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 110);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 32);
            label5.TabIndex = 25;
            label5.Text = "Цена:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxIsOccupied
            // 
            checkBoxIsOccupied.AutoSize = true;
            checkBoxIsOccupied.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxIsOccupied.Location = new System.Drawing.Point(168, 145);
            checkBoxIsOccupied.Name = "checkBoxIsOccupied";
            checkBoxIsOccupied.Size = new System.Drawing.Size(516, 26);
            checkBoxIsOccupied.TabIndex = 26;
            checkBoxIsOccupied.UseVisualStyleBackColor = true;
            // 
            // SeatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(717, 255);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeatForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление посадочного места";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion
        private System.Windows.Forms.Button SelectSportEventButton;
        private System.Windows.Forms.TextBox textSeatName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textSportEventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxIsOccupied;
    }
}