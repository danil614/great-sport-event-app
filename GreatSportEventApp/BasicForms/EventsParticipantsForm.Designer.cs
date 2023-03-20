
namespace GreatSportEventApp.BasicForms
{
    partial class EventsParticipantsForm
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
            components = new System.ComponentModel.Container();
            MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MainImageList = new System.Windows.Forms.ImageList(components);
            labelTitle = new System.Windows.Forms.Label();
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            MainTreeView = new System.Windows.Forms.TreeView();
            MainContextMenuStrip.SuspendLayout();
            MainToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainContextMenuStrip
            // 
            MainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { CreateToolStripMenuItem, EditToolStripMenuItem, DeleteToolStripMenuItem });
            MainContextMenuStrip.Name = "MainContextMenuStrip";
            MainContextMenuStrip.Size = new System.Drawing.Size(133, 82);
            MainContextMenuStrip.Opening += MainContextMenuStrip_Opening;
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Image = Properties.Resources.create;
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = Properties.Resources.edit;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            EditToolStripMenuItem.Text = "Изменить";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Image = Properties.Resources.delete;
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripButton_Click;
            // 
            // MainImageList
            // 
            MainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            MainImageList.ImageSize = new System.Drawing.Size(16, 16);
            MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.SystemColors.Control;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(843, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Спортивные мероприятия и участники";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            MainToolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator1, CreateToolStripButton, toolStripSeparator2, toolStripLabel1, toolStripSeparator6, EditToolStripButton, toolStripSeparator3, DeleteToolStripButton, toolStripSeparator4, UpdateToolStripButton, toolStripSeparator5 });
            MainToolStrip.Location = new System.Drawing.Point(0, 40);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new System.Drawing.Size(843, 27);
            MainToolStrip.TabIndex = 3;
            MainToolStrip.Text = "MainToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // CreateToolStripButton
            // 
            CreateToolStripButton.Image = Properties.Resources.create;
            CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CreateToolStripButton.Name = "CreateToolStripButton";
            CreateToolStripButton.Size = new System.Drawing.Size(161, 24);
            CreateToolStripButton.Text = "Создать мероприятие";
            CreateToolStripButton.Click += CreateToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(120, 24);
            toolStripLabel1.Text = "Текущая вершина:";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // EditToolStripButton
            // 
            EditToolStripButton.Image = Properties.Resources.edit;
            EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditToolStripButton.Name = "EditToolStripButton";
            EditToolStripButton.Size = new System.Drawing.Size(88, 24);
            EditToolStripButton.Text = "Изменить";
            EditToolStripButton.Click += EditToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // DeleteToolStripButton
            // 
            DeleteToolStripButton.Image = Properties.Resources.delete;
            DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DeleteToolStripButton.Name = "DeleteToolStripButton";
            DeleteToolStripButton.Size = new System.Drawing.Size(79, 24);
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
            UpdateToolStripButton.Image = Properties.Resources.update;
            UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            UpdateToolStripButton.Name = "UpdateToolStripButton";
            UpdateToolStripButton.Size = new System.Drawing.Size(88, 24);
            UpdateToolStripButton.Text = "Обновить";
            UpdateToolStripButton.Click += UpdateToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // MainTreeView
            // 
            MainTreeView.AllowDrop = true;
            MainTreeView.ContextMenuStrip = MainContextMenuStrip;
            MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTreeView.Location = new System.Drawing.Point(0, 67);
            MainTreeView.Name = "MainTreeView";
            MainTreeView.Size = new System.Drawing.Size(843, 396);
            MainTreeView.TabIndex = 4;
            MainTreeView.BeforeExpand += MainTreeView_BeforeExpand;
            MainTreeView.ItemDrag += MainTreeView_ItemDrag;
            MainTreeView.AfterSelect += MainTreeView_AfterSelect;
            MainTreeView.DragDrop += MainTreeView_DragDrop;
            // 
            // TreeForm
            // 
            ClientSize = new System.Drawing.Size(843, 463);
            Controls.Add(MainTreeView);
            Controls.Add(MainToolStrip);
            Controls.Add(labelTitle);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "TreeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Спортивные мероприятия и участники";
            Load += TreeForm_Load;
            MainContextMenuStrip.ResumeLayout(false);
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
