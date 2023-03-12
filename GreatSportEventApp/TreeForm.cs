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
            MainTreeView_SetActivity(null, null);
        }

        private void UpdateTreeView()
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
                node.Checked = false;

                if (!(sportEvent["teams"] is DBNull))
                {
                    node.Nodes.Add("Temp");
                }
                MainTreeView.Nodes.Add(node);
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
            MainTreeView_SetActivity(null, null);
        }

        #endregion

        #region Активность кнопок

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

        private void MainTreeView_SetActivity(object sender, TreeViewEventArgs e)
        {
            if (MainTreeView.SelectedNode == null)
            {
                CreateToolStripButton.Enabled = false;
                EditToolStripButton.Enabled = false;
                DeleteToolStripButton.Enabled = false;
            }
            else
            {
                CreateToolStripButton.Enabled = true;
                EditToolStripButton.Enabled = true;
                DeleteToolStripButton.Enabled = true;
            }
        }

        #endregion

        private void MainTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var currentNode = e.Node;
            if (currentNode != null && !currentNode.Checked)
            {
                currentNode.Nodes.Clear();
                currentNode.Checked = true;

                switch (currentNode.Level)
                {
                    case 0:
                        var teams = Query.GetListTeamsBySportEvent(out bool isConnected, (int)currentNode.Tag).AsEnumerable();

                        if (!isConnected)
                        {
                            MessageBox.Show(@"Отсутствует подключение!");
                            return;
                        }

                        foreach (var team in teams)
                        {
                            var node = new TreeNode(team["name"].ToString());
                            node.Tag = team["id"];
                            node.Checked = false;

                            if (!(team["athletes"] is DBNull))
                            {
                                node.Nodes.Add("Temp");
                            }

                            currentNode.Nodes.Add(node);
                        }
                        break;
                    case 1:
                        var athletes = Query.GetListAthletesByTeam(out isConnected, (int)currentNode.Tag).AsEnumerable();

                        if (!isConnected)
                        {
                            MessageBox.Show(@"Отсутствует подключение!");
                            return;
                        }

                        foreach (var athlete in athletes)
                        {
                            var node = new TreeNode(athlete["name"].ToString());
                            node.Tag = athlete["id"];
                            node.Checked = false;
                            currentNode.Nodes.Add(node);
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
