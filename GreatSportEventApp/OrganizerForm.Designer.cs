using System.ComponentModel;

namespace GreatSportEventApp
{
    partial class OrganizerForm
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
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.buttonChangeLocation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLocationsGroup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocationsGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLocations
            // 
            this.dataLocations.AllowUserToAddRows = false;
            this.dataLocations.AllowUserToDeleteRows = false;
            this.dataLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocations.Location = new System.Drawing.Point(7, 39);
            this.dataLocations.Margin = new System.Windows.Forms.Padding(4);
            this.dataLocations.Name = "dataLocations";
            this.dataLocations.ReadOnly = true;
            this.dataLocations.Size = new System.Drawing.Size(1257, 531);
            this.dataLocations.TabIndex = 0;
            this.dataLocations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataLocations_CellMouseDoubleClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(7, 3);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(251, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Места расположения:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddLocation.Location = new System.Drawing.Point(6, 576);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(192, 40);
            this.buttonAddLocation.TabIndex = 2;
            this.buttonAddLocation.Text = "Добавить место";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // buttonChangeLocation
            // 
            this.buttonChangeLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeLocation.Location = new System.Drawing.Point(204, 576);
            this.buttonChangeLocation.Name = "buttonChangeLocation";
            this.buttonChangeLocation.Size = new System.Drawing.Size(192, 40);
            this.buttonChangeLocation.TabIndex = 3;
            this.buttonChangeLocation.Text = "Изменить место";
            this.buttonChangeLocation.UseVisualStyleBackColor = true;
            this.buttonChangeLocation.Click += new System.EventHandler(this.buttonChangeLocation_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 653);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataLocations);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.buttonAddLocation);
            this.tabPage1.Controls.Add(this.buttonChangeLocation);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список мест";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataLocationsGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Места с группировкой";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Места расположения с группировкой:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataLocationsGroup
            // 
            this.dataLocationsGroup.AllowUserToAddRows = false;
            this.dataLocationsGroup.AllowUserToDeleteRows = false;
            this.dataLocationsGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocationsGroup.Location = new System.Drawing.Point(7, 39);
            this.dataLocationsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.dataLocationsGroup.Name = "dataLocationsGroup";
            this.dataLocationsGroup.ReadOnly = true;
            this.dataLocationsGroup.Size = new System.Drawing.Size(1257, 576);
            this.dataLocationsGroup.TabIndex = 1;
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 681);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организатор | Спортивное мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLocationsGroup)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataLocationsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonChangeLocation;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataLocations;

        #endregion
    }
}