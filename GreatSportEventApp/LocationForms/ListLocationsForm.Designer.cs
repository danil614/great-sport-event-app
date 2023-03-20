using System.ComponentModel;

namespace GreatSportEventApp.LocationForms
{
    partial class ListLocationsForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ListLocationsForm));
            dataLocations = new System.Windows.Forms.DataGridView();
            labelTitle = new System.Windows.Forms.Label();
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            SelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((ISupportInitialize)dataLocations).BeginInit();
            MainToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataLocations
            // 
            dataLocations.AllowUserToAddRows = false;
            dataLocations.AllowUserToDeleteRows = false;
            dataLocations.BackgroundColor = System.Drawing.SystemColors.Window;
            dataLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLocations.Location = new System.Drawing.Point(0, 65);
            dataLocations.Margin = new System.Windows.Forms.Padding(4);
            dataLocations.Name = "dataLocations";
            dataLocations.ReadOnly = true;
            dataLocations.Size = new System.Drawing.Size(809, 445);
            dataLocations.TabIndex = 0;
            dataLocations.CellMouseDoubleClick += DataLocations_CellMouseDoubleClick;
            dataLocations.CurrentCellChanged += DataLocations_CurrentCellChanged;
            dataLocations.Click += DataLocations_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.SystemColors.Control;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(809, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Места расположения";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            MainToolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SelectToolStripButton, toolStripSeparator1, CreateToolStripButton, toolStripSeparator2, EditToolStripButton, toolStripSeparator3, DeleteToolStripButton, toolStripSeparator4, UpdateToolStripButton, toolStripSeparator5, ExportToolStripButton });
            MainToolStrip.Location = new System.Drawing.Point(0, 40);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new System.Drawing.Size(809, 25);
            MainToolStrip.TabIndex = 5;
            MainToolStrip.Text = "MainToolStrip";
            // 
            // SelectToolStripButton
            // 
            SelectToolStripButton.AutoSize = false;
            SelectToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SelectToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            SelectToolStripButton.Image = Properties.Resources.select;
            SelectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            SelectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SelectToolStripButton.Name = "SelectToolStripButton";
            SelectToolStripButton.Size = new System.Drawing.Size(200, 22);
            SelectToolStripButton.Text = "Выбрать";
            SelectToolStripButton.Click += SelectToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CreateToolStripButton
            // 
            CreateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CreateToolStripButton.Image = Properties.Resources.create;
            CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CreateToolStripButton.Name = "CreateToolStripButton";
            CreateToolStripButton.Size = new System.Drawing.Size(81, 22);
            CreateToolStripButton.Text = "Создать";
            CreateToolStripButton.Click += CreateToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditToolStripButton
            // 
            EditToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            EditToolStripButton.Image = Properties.Resources.edit;
            EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditToolStripButton.Name = "EditToolStripButton";
            EditToolStripButton.Size = new System.Drawing.Size(90, 22);
            EditToolStripButton.Text = "Изменить";
            EditToolStripButton.Click += EditToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteToolStripButton
            // 
            DeleteToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DeleteToolStripButton.Image = Properties.Resources.delete;
            DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DeleteToolStripButton.Name = "DeleteToolStripButton";
            DeleteToolStripButton.Size = new System.Drawing.Size(80, 22);
            DeleteToolStripButton.Text = "Удалить";
            DeleteToolStripButton.Click += DeleteToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // UpdateToolStripButton
            // 
            UpdateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UpdateToolStripButton.Image = Properties.Resources.update;
            UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            UpdateToolStripButton.Name = "UpdateToolStripButton";
            UpdateToolStripButton.Size = new System.Drawing.Size(91, 22);
            UpdateToolStripButton.Text = "Обновить";
            UpdateToolStripButton.Click += UpdateToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ExportToolStripButton
            // 
            ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            ExportToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ExportToolStripButton.Image = (System.Drawing.Image)resources.GetObject("ExportToolStripButton.Image");
            ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExportToolStripButton.Name = "ExportToolStripButton";
            ExportToolStripButton.Size = new System.Drawing.Size(64, 22);
            ExportToolStripButton.Text = "Экспорт";
            ExportToolStripButton.Click += ExportToolStripButton_Click;
            // 
            // ListLocationsForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(809, 510);
            Controls.Add(dataLocations);
            Controls.Add(MainToolStrip);
            Controls.Add(labelTitle);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ListLocationsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Места расположения";
            ((ISupportInitialize)dataLocations).EndInit();
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataLocations;

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton SelectToolStripButton;
        private System.Windows.Forms.ToolStripButton ExportToolStripButton;
    }
}