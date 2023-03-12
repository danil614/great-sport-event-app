using GreatSportEventApp.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class TreeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            using (var context = new GreatSportEventContext())
            {
                var sportEvents = Query.GetListSportEventsString(out bool isConnected).AsEnumerable();

                if (!isConnected)
                {
                    MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                foreach (var sportEvent in sportEvents)
                {
                    var node = new TreeNode(sportEvent["name"].ToString());
                    node.Tag = sportEvent["id"];

                    if (!(sportEvent["teams"] is DBNull))
                    {
                        node.Nodes.Add("Temp");
                    }
                    MainTreeView.Nodes.Add(node);
                }
            }
        }

        private void MainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (MainTreeView.SelectedNode == null)
            {
                CreateToolStripMenuItem.Enabled = false;
                EditToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                CreateToolStripMenuItem.Enabled = true;
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
        }

        #region Операции с базой данных

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (MainTreeView.SelectedNode != null && MainTreeView.SelectedNode.Level == 1)
            {

            }
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            MainTreeView.Nodes.Clear();
            UpdateTreeView();
        }

        #endregion
    }
}
