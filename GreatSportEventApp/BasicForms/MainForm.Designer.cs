
namespace GreatSportEventApp.BasicForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.TreeFormToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ListLocationsFormToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CitiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutFormToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.PositionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.LoginToolStripButton,
            this.toolStripSeparator8,
            this.TreeFormToolStripButton,
            this.toolStripSeparator2,
            this.ListLocationsFormToolStripButton,
            this.toolStripSeparator7,
            this.CitiesToolStripButton,
            this.toolStripSeparator5,
            this.PositionsToolStripButton,
            this.toolStripSeparator4,
            this.AboutFormToolStripButton,
            this.toolStripSeparator3});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MainToolStrip.Size = new System.Drawing.Size(1137, 31);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "mainToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // LoginToolStripButton
            // 
            this.LoginToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.login;
            this.LoginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoginToolStripButton.Name = "LoginToolStripButton";
            this.LoginToolStripButton.Size = new System.Drawing.Size(75, 28);
            this.LoginToolStripButton.Text = "Войти";
            this.LoginToolStripButton.Click += new System.EventHandler(this.LoginToolStripButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // TreeFormToolStripButton
            // 
            this.TreeFormToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TreeFormToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TreeFormToolStripButton.Image")));
            this.TreeFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TreeFormToolStripButton.Name = "TreeFormToolStripButton";
            this.TreeFormToolStripButton.Size = new System.Drawing.Size(199, 28);
            this.TreeFormToolStripButton.Text = "Спортивные мероприятия";
            this.TreeFormToolStripButton.Click += new System.EventHandler(this.TreeFormToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ListLocationsFormToolStripButton
            // 
            this.ListLocationsFormToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListLocationsFormToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ListLocationsFormToolStripButton.Image")));
            this.ListLocationsFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListLocationsFormToolStripButton.Name = "ListLocationsFormToolStripButton";
            this.ListLocationsFormToolStripButton.Size = new System.Drawing.Size(163, 28);
            this.ListLocationsFormToolStripButton.Text = "Места расположения";
            this.ListLocationsFormToolStripButton.Click += new System.EventHandler(this.ListLocationsFormToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // CitiesToolStripButton
            // 
            this.CitiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CitiesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CitiesToolStripButton.Image")));
            this.CitiesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CitiesToolStripButton.Name = "CitiesToolStripButton";
            this.CitiesToolStripButton.Size = new System.Drawing.Size(63, 28);
            this.CitiesToolStripButton.Text = "Города";
            this.CitiesToolStripButton.Click += new System.EventHandler(this.CitiesToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // AboutFormToolStripButton
            // 
            this.AboutFormToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutFormToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutFormToolStripButton.Image")));
            this.AboutFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutFormToolStripButton.Name = "AboutFormToolStripButton";
            this.AboutFormToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.AboutFormToolStripButton.Text = "Спр&авка";
            this.AboutFormToolStripButton.Click += new System.EventHandler(this.AboutFormToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // mainDockPanel
            // 
            this.mainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDockPanel.Location = new System.Drawing.Point(0, 31);
            this.mainDockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainDockPanel.Name = "mainDockPanel";
            this.mainDockPanel.Size = new System.Drawing.Size(1137, 684);
            this.mainDockPanel.TabIndex = 2;
            // 
            // PositionsToolStripButton
            // 
            this.PositionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PositionsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PositionsToolStripButton.Image")));
            this.PositionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PositionsToolStripButton.Name = "PositionsToolStripButton";
            this.PositionsToolStripButton.Size = new System.Drawing.Size(91, 28);
            this.PositionsToolStripButton.Text = "Должности";
            this.PositionsToolStripButton.Click += new System.EventHandler(this.PositionsToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1137, 715);
            this.Controls.Add(this.mainDockPanel);
            this.Controls.Add(this.MainToolStrip);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организация спортивных мероприятий";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton AboutFormToolStripButton;
        private WeifenLuo.WinFormsUI.Docking.DockPanel mainDockPanel;
        private System.Windows.Forms.ToolStripButton LoginToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton TreeFormToolStripButton;
        private System.Windows.Forms.ToolStripButton ListLocationsFormToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CitiesToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton PositionsToolStripButton;
    }
}