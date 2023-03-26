using System.ComponentModel;

namespace GreatSportEventApp.SimpleForms
{
    partial class PositionsForm
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
            dataView = new System.Windows.Forms.DataGridView();
            labelTitle = new System.Windows.Forms.Label();
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            ((ISupportInitialize)dataView).BeginInit();
            MainToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToDeleteRows = false;
            dataView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataView.Location = new System.Drawing.Point(0, 67);
            dataView.Margin = new System.Windows.Forms.Padding(4);
            dataView.MultiSelect = false;
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new System.Drawing.Size(864, 441);
            dataView.TabIndex = 0;
            dataView.CellValueChanged += DataView_CellValueChanged;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.SystemColors.Control;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new System.Windows.Forms.Padding(5);
            labelTitle.Size = new System.Drawing.Size(864, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Должности";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            MainToolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator1, CreateToolStripButton, toolStripSeparator2, EditToolStripButton, toolStripSeparator3, DeleteToolStripButton, toolStripSeparator4, UpdateToolStripButton, toolStripSeparator5, toolStripLabel1, toolStripTextBoxFilter, toolStripSeparator6, ExportToolStripButton, toolStripSeparator7 });
            MainToolStrip.Location = new System.Drawing.Point(0, 40);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new System.Drawing.Size(864, 27);
            MainToolStrip.TabIndex = 5;
            MainToolStrip.Text = "MainToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // CreateToolStripButton
            // 
            CreateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CreateToolStripButton.Image = Properties.Resources.create;
            CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CreateToolStripButton.Name = "CreateToolStripButton";
            CreateToolStripButton.Size = new System.Drawing.Size(85, 24);
            CreateToolStripButton.Text = "Создать";
            CreateToolStripButton.Click += CreateToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // EditToolStripButton
            // 
            EditToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            EditToolStripButton.Image = Properties.Resources.edit;
            EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditToolStripButton.Name = "EditToolStripButton";
            EditToolStripButton.Size = new System.Drawing.Size(94, 24);
            EditToolStripButton.Text = "Изменить";
            EditToolStripButton.Click += EditToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // DeleteToolStripButton
            // 
            DeleteToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DeleteToolStripButton.Image = Properties.Resources.delete;
            DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DeleteToolStripButton.Name = "DeleteToolStripButton";
            DeleteToolStripButton.Size = new System.Drawing.Size(84, 24);
            DeleteToolStripButton.Text = "Удалить";
            DeleteToolStripButton.Click += DeleteToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // UpdateToolStripButton
            // 
            UpdateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UpdateToolStripButton.Image = Properties.Resources.update;
            UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            UpdateToolStripButton.Name = "UpdateToolStripButton";
            UpdateToolStripButton.Size = new System.Drawing.Size(95, 24);
            UpdateToolStripButton.Text = "Обновить";
            UpdateToolStripButton.Click += UpdateToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(140, 24);
            toolStripLabel1.Text = "Поиск по названию:";
            // 
            // toolStripTextBoxFilter
            // 
            toolStripTextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            toolStripTextBoxFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            toolStripTextBoxFilter.Size = new System.Drawing.Size(160, 27);
            toolStripTextBoxFilter.TextChanged += ToolStripTextBoxFilter_TextChanged;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // ExportToolStripButton
            // 
            ExportToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ExportToolStripButton.Image = Properties.Resources.export;
            ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExportToolStripButton.Name = "ExportToolStripButton";
            ExportToolStripButton.Size = new System.Drawing.Size(84, 24);
            ExportToolStripButton.Text = "Экспорт";
            ExportToolStripButton.Click += ExportToolStripButton_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // PositionsForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(864, 508);
            Controls.Add(dataView);
            Controls.Add(MainToolStrip);
            Controls.Add(labelTitle);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "PositionsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Должности";
            ((ISupportInitialize)dataView).EndInit();
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataView;

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ExportToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}