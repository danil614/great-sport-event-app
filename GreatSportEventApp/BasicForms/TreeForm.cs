using GreatSportEventApp.Entities;
using GreatSportEventApp.SportEventForms;
using GreatSportEventApp.TeamForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.BasicForms
{
    public partial class TreeForm : DockContent
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
            MainTreeView.Nodes.Clear();
            var sportEvents = Query.GetListSportEvents(out bool isConnected).AsEnumerable();

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

            MainTreeViewSetActivity();
        }

        #region Операции с базой данных

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            // Создаем спортивное мероприятие
            var sportEventForm = new SportEventForm(false, -1);
            sportEventForm.ShowDialog();

            if (sportEventForm.SportEventId != -1)
            {
                var node = new TreeNode(sportEventForm.SportEventString);
                node.Tag = sportEventForm.SportEventId;
                node.Checked = false;
                MainTreeView.Nodes.Add(node);
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentNode = MainTreeView.SelectedNode;
            if (currentNode != null)
            {
                switch (currentNode.Level)
                {
                    case 0:
                        // Создаем команду для участия в спортивном мероприятия
                        break;
                    case 1:
                        // Создаем спортсменов в команду
                        break;
                    default:
                        break;
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentNode = MainTreeView.SelectedNode;
            if (currentNode != null)
            {
                switch (currentNode.Level)
                {
                    case 0:
                        // Изменяем спортивное мероприятие
                        var sportEventForm = new SportEventForm(true, (int)currentNode.Tag);
                        sportEventForm.ShowDialog();
                        if (sportEventForm.SportEventString != "")
                            currentNode.Text = sportEventForm.SportEventString;
                        break;
                    case 1:
                        // Изменяем команду
                        var teamForm = new TeamForm(true, (int)currentNode.Tag);
                        teamForm.ShowDialog();
                        if (teamForm.TeamString != "")
                            currentNode.Text = teamForm.TeamString;
                        break;
                    case 2:
                        // Изменяем спортсмена
                        break;
                }
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        #endregion

        #region Активность кнопок

        private void MainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var isEnabled = MainTreeView.SelectedNode != null;

            CreateToolStripMenuItem.Enabled = isEnabled;
            EditToolStripMenuItem.Enabled = isEnabled;
            DeleteToolStripMenuItem.Enabled = isEnabled;
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainTreeViewSetActivity();
        }

        private void MainTreeViewSetActivity()
        {
            var isEnabled = MainTreeView.SelectedNode != null;

            CreateToolStripButton.Enabled = isEnabled;
            EditToolStripButton.Enabled = isEnabled;
            DeleteToolStripButton.Enabled = isEnabled;
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
