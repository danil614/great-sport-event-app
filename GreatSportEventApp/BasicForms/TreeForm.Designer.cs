
namespace GreatSportEventApp.BasicForms
{
    partial class TreeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MainContextMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(152, 82);
            this.MainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MainContextMenuStrip_Opening);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.create;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.edit;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.delete;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // MainImageList
            // 
            this.MainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.MainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(843, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Спортивные мероприятия";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainToolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.CreateToolStripButton,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.EditToolStripButton,
            this.toolStripSeparator3,
            this.DeleteToolStripButton,
            this.toolStripSeparator4,
            this.UpdateToolStripButton,
            this.toolStripSeparator5});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 40);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(843, 27);
            this.MainToolStrip.TabIndex = 3;
            this.MainToolStrip.Text = "MainToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // CreateToolStripButton
            // 
            this.CreateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.create;
            this.CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripButton.Name = "CreateToolStripButton";
            this.CreateToolStripButton.Size = new System.Drawing.Size(203, 24);
            this.CreateToolStripButton.Text = "Создать мероприятие";
            this.CreateToolStripButton.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.edit;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(108, 24);
            this.EditToolStripButton.Text = "Изменить";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.delete;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(98, 24);
            this.DeleteToolStripButton.Text = "Удалить";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.update;
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(107, 24);
            this.UpdateToolStripButton.Text = "Обновить";
            this.UpdateToolStripButton.Click += new System.EventHandler(this.UpdateToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // MainTreeView
            // 
            this.MainTreeView.ContextMenuStrip = this.MainContextMenuStrip;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 67);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(843, 396);
            this.MainTreeView.TabIndex = 4;
            this.MainTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.MainTreeView_BeforeExpand);
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(152, 24);
            this.toolStripLabel1.Text = "Текущая вершина:";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // TreeForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 463);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивные мероприятия";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.MainContextMenuStrip.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}
