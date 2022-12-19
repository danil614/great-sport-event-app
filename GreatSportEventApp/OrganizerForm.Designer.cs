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
            this.buttonAddViewer = new System.Windows.Forms.Button();
            this.buttonChangeViewer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLocations
            // 
            this.dataLocations.AllowUserToAddRows = false;
            this.dataLocations.AllowUserToDeleteRows = false;
            this.dataLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocations.Location = new System.Drawing.Point(13, 45);
            this.dataLocations.Margin = new System.Windows.Forms.Padding(4);
            this.dataLocations.Name = "dataLocations";
            this.dataLocations.ReadOnly = true;
            this.dataLocations.Size = new System.Drawing.Size(1162, 573);
            this.dataLocations.TabIndex = 0;
            this.dataLocations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataLocations_CellMouseDoubleClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(13, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(251, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Места расположения:";
            // 
            // buttonAddViewer
            // 
            this.buttonAddViewer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddViewer.Location = new System.Drawing.Point(13, 625);
            this.buttonAddViewer.Name = "buttonAddViewer";
            this.buttonAddViewer.Size = new System.Drawing.Size(192, 40);
            this.buttonAddViewer.TabIndex = 2;
            this.buttonAddViewer.Text = "Добавить место";
            this.buttonAddViewer.UseVisualStyleBackColor = true;
            this.buttonAddViewer.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // buttonChangeViewer
            // 
            this.buttonChangeViewer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeViewer.Location = new System.Drawing.Point(211, 625);
            this.buttonChangeViewer.Name = "buttonChangeViewer";
            this.buttonChangeViewer.Size = new System.Drawing.Size(192, 40);
            this.buttonChangeViewer.TabIndex = 3;
            this.buttonChangeViewer.Text = "Изменить место";
            this.buttonChangeViewer.UseVisualStyleBackColor = true;
            this.buttonChangeViewer.Click += new System.EventHandler(this.buttonChangeLocation_Click);
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 678);
            this.Controls.Add(this.buttonChangeViewer);
            this.Controls.Add(this.buttonAddViewer);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataLocations);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организатор | Спортивное мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.dataLocations)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonChangeViewer;

        private System.Windows.Forms.Button buttonAddViewer;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.DataGridView dataLocations;

        #endregion
    }
}