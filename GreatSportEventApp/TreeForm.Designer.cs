
namespace GreatSportEventApp
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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.MainToolStrip.SuspendLayout();
            this.MainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripButton,
            this.EditToolStripButton,
            this.DeleteToolStripButton,
            this.UpdateToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(733, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "MainToolStrip";
            // 
            // CreateToolStripButton
            // 
            this.CreateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.create;
            this.CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripButton.Name = "CreateToolStripButton";
            this.CreateToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.CreateToolStripButton.Text = "Создать";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.edit;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.EditToolStripButton.Text = "Изменить";
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.delete;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.DeleteToolStripButton.Text = "Удалить";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.Image = global::GreatSportEventApp.Properties.Resources.update;
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.UpdateToolStripButton.Text = "Обновить";
            this.UpdateToolStripButton.Click += new System.EventHandler(this.UpdateToolStripButton_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(129, 70);
            this.MainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MainContextMenuStrip_Opening);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.create;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.edit;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::GreatSportEventApp.Properties.Resources.delete;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // MainImageList
            // 
            this.MainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.MainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainTreeView
            // 
            this.MainTreeView.ContextMenuStrip = this.MainContextMenuStrip;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 25);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(733, 414);
            this.MainTreeView.TabIndex = 1;
            this.MainTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.MainTreeView_BeforeExpand);
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_SetActivity);
            // 
            // TreeForm
            // 
            this.ClientSize = new System.Drawing.Size(733, 439);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainToolStrip);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивные мероприятия";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.TreeView MainTreeView;
    }
}
