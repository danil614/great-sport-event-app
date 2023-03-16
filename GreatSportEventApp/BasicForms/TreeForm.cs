using GreatSportEventApp.Entities;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SportEventForms;
using GreatSportEventApp.TeamForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
                        var teamForm = new TeamForm(false, -1, (int)currentNode.Tag);
                        teamForm.ShowDialog();

                        if (teamForm.TeamId != -1)
                        {
                            var node = new TreeNode(teamForm.TeamString);
                            node.Tag = teamForm.TeamId;
                            node.Checked = false;
                            currentNode.Nodes.Add(node);
                        }
                        break;
                    case 1:
                        // Создаем спортсменов в команду
                        var athleteForm = new AthleteForm(false, -1, (int)currentNode.Tag);
                        athleteForm.ShowDialog();

                        if (athleteForm.AthleteId != -1)
                        {
                            var node = new TreeNode(athleteForm.AthleteString);
                            node.Tag = athleteForm.AthleteId;
                            node.Checked = false;
                            currentNode.Nodes.Add(node);
                        }
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
                        var teamForm = new TeamForm(true, (int)currentNode.Tag, (int)currentNode.Parent.Tag);
                        teamForm.ShowDialog();
                        if (teamForm.TeamString != "")
                            currentNode.Text = teamForm.TeamString;
                        break;
                    case 2:
                        // Изменяем спортсмена
                        var athleteForm = new AthleteForm(true, (int)currentNode.Tag, (int)currentNode.Parent.Tag);
                        athleteForm.ShowDialog();
                        if (athleteForm.AthleteString != "")
                            currentNode.Text = athleteForm.AthleteString;
                        break;
                }
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            var currentNode = MainTreeView.SelectedNode;
            if (currentNode != null)
            {
                switch (currentNode.Level)
                {
                    case 0:
                        // Удаляем спортивное мероприятие
                        DeleteSportEventById((int)currentNode.Tag);
                        break;
                    case 1:
                        // Удаляем команду
                        DeleteTeamById((int)currentNode.Tag, (int)currentNode.Parent.Tag, currentNode.Nodes.Count);
                        break;
                    case 2:
                        // Изменяем спортсмена
                        DeleteAthleteById((int)currentNode.Tag);
                        break;
                }
            }
        }

        private void DeleteSportEventById(int sportEventId)
        {
            using (var context = new GreatSportEventContext())
            {
                var sportEvent = context.SportEvents.Find(sportEventId);

                if (sportEvent is null)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                context.SportEvents.Remove(sportEvent);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            MainTreeView.SelectedNode.Remove();
        }

        private void DeleteTeamById(int teamId, int sportEventId, int numberChildren)
        {
            if (numberChildren > 0)
            {
                MessageBox.Show(@"Невозможно удалить запись!");
                return;
            }

            using (var context = new GreatSportEventContext())
            {
                var paticipationEvent = context.ParticipationEvents.Find(sportEventId, teamId);

                if (paticipationEvent is null)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                context.ParticipationEvents.Remove(paticipationEvent);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            MainTreeView.SelectedNode.Remove();
        }

        private void DeleteAthleteById(int athleteId)
        {
            using (var context = new GreatSportEventContext())
            {
                var athlete = context.Athletes.Find(athleteId);

                if (athlete is null)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                context.Athletes.Remove(athlete);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            MainTreeView.SelectedNode.Remove();
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
