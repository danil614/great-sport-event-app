using System.ComponentModel;

namespace GreatSportEventApp
{
    partial class SellerForm
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
            this.dataViewers = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAddViewer = new System.Windows.Forms.Button();
            this.buttonChangeViewer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.dataTickets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewers
            // 
            this.dataViewers.AllowUserToAddRows = false;
            this.dataViewers.AllowUserToDeleteRows = false;
            this.dataViewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewers.Location = new System.Drawing.Point(7, 39);
            this.dataViewers.Margin = new System.Windows.Forms.Padding(4);
            this.dataViewers.Name = "dataViewers";
            this.dataViewers.ReadOnly = true;
            this.dataViewers.Size = new System.Drawing.Size(981, 573);
            this.dataViewers.TabIndex = 0;
            this.dataViewers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewers_CellMouseDoubleClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(7, 3);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Зрители:";
            // 
            // buttonAddViewer
            // 
            this.buttonAddViewer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddViewer.Location = new System.Drawing.Point(7, 619);
            this.buttonAddViewer.Name = "buttonAddViewer";
            this.buttonAddViewer.Size = new System.Drawing.Size(192, 40);
            this.buttonAddViewer.TabIndex = 2;
            this.buttonAddViewer.Text = "Добавить зрителя";
            this.buttonAddViewer.UseVisualStyleBackColor = true;
            this.buttonAddViewer.Click += new System.EventHandler(this.buttonAddViewer_Click);
            // 
            // buttonChangeViewer
            // 
            this.buttonChangeViewer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeViewer.Location = new System.Drawing.Point(205, 619);
            this.buttonChangeViewer.Name = "buttonChangeViewer";
            this.buttonChangeViewer.Size = new System.Drawing.Size(192, 40);
            this.buttonChangeViewer.TabIndex = 3;
            this.buttonChangeViewer.Text = "Изменить зрителя";
            this.buttonChangeViewer.UseVisualStyleBackColor = true;
            this.buttonChangeViewer.Click += new System.EventHandler(this.buttonChangeViewer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 703);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSelect);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.dataViewers);
            this.tabPage1.Controls.Add(this.buttonChangeViewer);
            this.tabPage1.Controls.Add(this.buttonAddViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зрители";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(796, 619);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(192, 40);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Выбрать зрителя";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textPrice);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textSeat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonCreateTicket);
            this.tabPage2.Controls.Add(this.dataTickets);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ билетов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(314, 627);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 26);
            this.textPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSeat
            // 
            this.textSeat.BackColor = System.Drawing.SystemColors.Window;
            this.textSeat.Location = new System.Drawing.Point(100, 626);
            this.textSeat.Name = "textSeat";
            this.textSeat.Size = new System.Drawing.Size(100, 26);
            this.textSeat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCreateTicket
            // 
            this.buttonCreateTicket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTicket.Location = new System.Drawing.Point(796, 619);
            this.buttonCreateTicket.Name = "buttonCreateTicket";
            this.buttonCreateTicket.Size = new System.Drawing.Size(192, 40);
            this.buttonCreateTicket.TabIndex = 5;
            this.buttonCreateTicket.Text = "Выпустить билет";
            this.buttonCreateTicket.UseVisualStyleBackColor = true;
            this.buttonCreateTicket.Click += new System.EventHandler(this.buttonCreateTicket_Click);
            // 
            // dataTickets
            // 
            this.dataTickets.AllowUserToAddRows = false;
            this.dataTickets.AllowUserToDeleteRows = false;
            this.dataTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTickets.Location = new System.Drawing.Point(7, 39);
            this.dataTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dataTickets.Name = "dataTickets";
            this.dataTickets.ReadOnly = true;
            this.dataTickets.Size = new System.Drawing.Size(981, 560);
            this.dataTickets.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Билеты:";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1035, 720);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продавец | Спортивное мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTickets)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textPrice;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSeat;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button buttonCreateTicket;

        private System.Windows.Forms.DataGridView dataTickets;
        private System.Windows.Forms.Button buttonSelect;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Button buttonChangeViewer;

        private System.Windows.Forms.Button buttonAddViewer;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.DataGridView dataViewers;

        #endregion
    }
}