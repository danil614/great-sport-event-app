using System.ComponentModel;

namespace GreatSportEventApp.SearchForms
{
    partial class SearchSportEventForm
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
            label2 = new System.Windows.Forms.Label();
            textLocationName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            buttonSearch = new System.Windows.Forms.Button();
            comboType = new System.Windows.Forms.ComboBox();
            dateTimeStart = new System.Windows.Forms.DateTimePicker();
            duration = new System.Windows.Forms.DateTimePicker();
            SelectLocationButton = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            comparisonDateStart = new System.Windows.Forms.ComboBox();
            comparisonLocation = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            dateTimeStop = new System.Windows.Forms.DateTimePicker();
            comparisonType = new System.Windows.Forms.ComboBox();
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
            label1.Size = new System.Drawing.Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "Место:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 3);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(827, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Поиск спортивного мероприятия";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 32);
            label2.TabIndex = 3;
            label2.Text = "Длительность:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLocationName
            // 
            textLocationName.Dock = System.Windows.Forms.DockStyle.Fill;
            textLocationName.Location = new System.Drawing.Point(3, 3);
            textLocationName.Name = "textLocationName";
            textLocationName.ReadOnly = true;
            textLocationName.Size = new System.Drawing.Size(425, 26);
            textLocationName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 32);
            label3.TabIndex = 6;
            label3.Text = "Начало:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 32);
            label4.TabIndex = 9;
            label4.Text = "Тип:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.Location = new System.Drawing.Point(630, 212);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(200, 50);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // comboType
            // 
            comboType.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType.FormattingEnabled = true;
            comboType.Location = new System.Drawing.Point(261, 49);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(569, 26);
            comboType.TabIndex = 4;
            // 
            // dateTimeStart
            // 
            dateTimeStart.AllowDrop = true;
            dateTimeStart.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimeStart.Location = new System.Drawing.Point(261, 113);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new System.Drawing.Size(207, 26);
            dateTimeStart.TabIndex = 15;
            dateTimeStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // duration
            // 
            duration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            duration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            duration.Location = new System.Drawing.Point(261, 180);
            duration.Name = "duration";
            duration.Size = new System.Drawing.Size(125, 26);
            duration.TabIndex = 16;
            duration.Value = new System.DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // SelectLocationButton
            // 
            SelectLocationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SelectLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectLocationButton.Location = new System.Drawing.Point(434, 3);
            SelectLocationButton.Name = "SelectLocationButton";
            SelectLocationButton.Size = new System.Drawing.Size(138, 26);
            SelectLocationButton.TabIndex = 17;
            SelectLocationButton.Text = "Выбрать";
            SelectLocationButton.UseVisualStyleBackColor = true;
            SelectLocationButton.Click += SelectLocationButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(comparisonDateStart, 0, 3);
            tableLayoutPanel1.Controls.Add(comparisonLocation, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 2);
            tableLayoutPanel1.Controls.Add(duration, 2, 5);
            tableLayoutPanel1.Controls.Add(dateTimeStart, 2, 3);
            tableLayoutPanel1.Controls.Add(comboType, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSearch, 2, 6);
            tableLayoutPanel1.Controls.Add(dateTimeStop, 2, 4);
            tableLayoutPanel1.Controls.Add(comparisonType, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(833, 283);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // comparisonDateStart
            // 
            comparisonDateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            comparisonDateStart.FormattingEnabled = true;
            comparisonDateStart.Items.AddRange(new object[] { " ", ">=", ">", "<=", "<" });
            comparisonDateStart.Location = new System.Drawing.Point(141, 113);
            comparisonDateStart.Name = "comparisonDateStart";
            comparisonDateStart.Size = new System.Drawing.Size(114, 26);
            comparisonDateStart.TabIndex = 24;
            // 
            // comparisonLocation
            // 
            comparisonLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            comparisonLocation.FormattingEnabled = true;
            comparisonLocation.Items.AddRange(new object[] { " ", "равно", "не равно" });
            comparisonLocation.Location = new System.Drawing.Point(141, 81);
            comparisonLocation.Name = "comparisonLocation";
            comparisonLocation.Size = new System.Drawing.Size(114, 26);
            comparisonLocation.TabIndex = 23;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 142);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(132, 35);
            label5.TabIndex = 21;
            label5.Text = "Начало:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(textLocationName, 0, 0);
            tableLayoutPanel2.Controls.Add(SelectLocationButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(258, 78);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(575, 32);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // dateTimeStop
            // 
            dateTimeStop.AllowDrop = true;
            dateTimeStop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dateTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimeStop.Location = new System.Drawing.Point(261, 145);
            dateTimeStop.Name = "dateTimeStop";
            dateTimeStop.Size = new System.Drawing.Size(207, 26);
            dateTimeStop.TabIndex = 20;
            dateTimeStop.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // comparisonType
            // 
            comparisonType.Dock = System.Windows.Forms.DockStyle.Fill;
            comparisonType.FormattingEnabled = true;
            comparisonType.Items.AddRange(new object[] { " ", "равно", "не равно" });
            comparisonType.Location = new System.Drawing.Point(141, 49);
            comparisonType.Name = "comparisonType";
            comparisonType.Size = new System.Drawing.Size(114, 26);
            comparisonType.TabIndex = 22;
            // 
            // SearchSportEventForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(843, 293);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchSportEventForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Поиск спортивного мероприятия";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker duration;
        private System.Windows.Forms.Button SelectLocationButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.ComboBox comparisonType;
        private System.Windows.Forms.ComboBox comparisonLocation;
        private System.Windows.Forms.ComboBox comparisonDateStart;
    }
}