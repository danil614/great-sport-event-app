using System.ComponentModel;

namespace GreatSportEventApp.TeamForms
{
    partial class ListTeamsForm
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
            this.dataLocations = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLocations
            // 
            this.dataLocations.AllowUserToAddRows = false;
            this.dataLocations.AllowUserToDeleteRows = false;
            this.dataLocations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLocations.Location = new System.Drawing.Point(0, 65);
            this.dataLocations.Margin = new System.Windows.Forms.Padding(4);
            this.dataLocations.Name = "dataLocations";
            this.dataLocations.ReadOnly = true;
            this.dataLocations.Size = new System.Drawing.Size(809, 445);
            this.dataLocations.TabIndex = 0;
            this.dataLocations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataLocations_CellMouseDoubleClick);
            this.dataLocations.CurrentCellChanged += new System.EventHandler(this.DataLocations_CurrentCellChanged);
            this.dataLocations.Click += new System.EventHandler(this.DataLocations_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(809, 40);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Места расположения";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainToolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectToolStripButton,
            this.toolStripSeparator1,
            this.CreateToolStripButton,
            this.toolStripSeparator2,
            this.EditToolStripButton,
            this.toolStripSeparator3,
            this.DeleteToolStripButton,
            this.toolStripSeparator4,
            this.UpdateToolStripButton,
            this.toolStripSeparator5});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 40);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(809, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "MainToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectToolStripButton
            // 
            this.SelectToolStripButton.AutoSize = false;
            this.SelectToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.select;
            this.SelectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectToolStripButton.Name = "SelectToolStripButton";
            this.SelectToolStripButton.Size = new System.Drawing.Size(200, 22);
            this.SelectToolStripButton.Text = "Выбрать";
            this.SelectToolStripButton.Click += new System.EventHandler(this.SelectToolStripButton_Click);
            // 
            // CreateToolStripButton
            // 
            this.CreateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.create;
            this.CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripButton.Name = "CreateToolStripButton";
            this.CreateToolStripButton.Size = new System.Drawing.Size(82, 22);
            this.CreateToolStripButton.Text = "Создать";
            this.CreateToolStripButton.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.edit;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(91, 22);
            this.EditToolStripButton.Text = "Изменить";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.delete;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.DeleteToolStripButton.Text = "Удалить";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.update;
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.UpdateToolStripButton.Text = "Обновить";
            this.UpdateToolStripButton.Click += new System.EventHandler(this.UpdateToolStripButton_Click);
            // 
            // ListLocationsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.dataLocations);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListLocationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Места расположения";
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}