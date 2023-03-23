using GreatSportEventApp.Entities;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SportEventForms;
using GreatSportEventApp.TeamForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.BasicForms
{
    public partial class EventsParticipantsForm : DockContent
    {
        public EventsParticipantsForm()
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
            EnumerableRowCollection<DataRow> sportEvents = Query.GetListSportEventsTeams(out bool isConnected).AsEnumerable();

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow sportEvent in sportEvents)
            {
                TreeNode node = new(sportEvent["name"].ToString())
                {
                    Tag = sportEvent["id"],
                    Checked = false
                };

                if (sportEvent["teams"] is not DBNull)
                {
                    _ = node.Nodes.Add("Temp");
                }
                _ = MainTreeView.Nodes.Add(node);
            }

            MainTreeViewSetActivity();
        }

        #region Операции с базой данных

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            // Создаем спортивное мероприятие
            SportEventForm sportEventForm = new(false, -1);
            _ = sportEventForm.ShowDialog();

            if (sportEventForm.SportEventId != -1)
            {
                TreeNode node = new(sportEventForm.SportEventString)
                {
                    Tag = sportEventForm.SportEventId,
                    Checked = false
                };
                _ = MainTreeView.Nodes.Add(node);
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = MainTreeView.SelectedNode;
            if (currentNode != null)
            {
                switch (currentNode.Level)
                {
                    case 0:
                        // Создаем команду для участия в спортивном мероприятии
                        CreateTeam();
                        break;
                    case 1:
                        // Создаем спортсменов в команду
                        AthleteForm athleteForm = new(false, -1, (int)currentNode.Tag);
                        _ = athleteForm.ShowDialog();

                        if (athleteForm.AthleteId != -1)
                        {
                            TreeNode node = new(athleteForm.AthleteString)
                            {
                                Tag = athleteForm.AthleteId,
                                Checked = false
                            };
                            _ = currentNode.Nodes.Add(node);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void CreateTeam()
        {
            TreeNode currentNode = MainTreeView.SelectedNode;

            ListTeamsForm teamsForm = new(true);
            teamsForm.ShowDialog();

            if (teamsForm.SelectedItem == null)
            {
                MessageBox.Show(@"Команда не выбрана!");
                return;
            }

            var teamId = (int)teamsForm.SelectedItem.Cells[0].Value;
            var sportEventId = (int)currentNode.Tag;

            if (teamId > 0 && sportEventId > 0)
            {
                bool isTeamNew;

                // Добавляем во вспомогательную таблицу
                using (GreatSportEventContext context = new())
                {
                    isTeamNew = TeamForm.UpdateParticipationEvent(context, sportEventId, teamId, 0);
                }

                var teamString = Query.GetTeamStringById(out bool isConnected, teamId, sportEventId);

                if (!isConnected)
                {
                    MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                if (isTeamNew)
                {
                    TreeNode node = new(teamString)
                    {
                        Tag = teamId,
                        Checked = false
                    };
                    node.Nodes.Add("Temp");

                    currentNode.Nodes.Add(node);
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = MainTreeView.SelectedNode;
            if (currentNode != null)
            {
                switch (currentNode.Level)
                {
                    case 0:
                        // Изменяем спортивное мероприятие
                        SportEventForm sportEventForm = new(true, (int)currentNode.Tag);
                        _ = sportEventForm.ShowDialog();
                        if (sportEventForm.SportEventString != "")
                        {
                            currentNode.Text = sportEventForm.SportEventString;
                        }

                        break;
                    case 1:
                        // Изменяем команду
                        TeamForm teamForm = new(true, (int)currentNode.Tag, (int)currentNode.Parent.Tag);
                        _ = teamForm.ShowDialog();
                        if (teamForm.TeamString != "")
                        {
                            currentNode.Text = teamForm.TeamString;
                        }

                        break;
                    case 2:
                        // Изменяем спортсмена
                        AthleteForm athleteForm = new(true, (int)currentNode.Tag, (int)currentNode.Parent.Tag);
                        _ = athleteForm.ShowDialog();
                        if (athleteForm.AthleteString != "")
                        {
                            currentNode.Text = athleteForm.AthleteString;
                        }

                        break;
                }
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = MainTreeView.SelectedNode;
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
            using (GreatSportEventContext context = new())
            {
                SportEvent sportEvent = context.SportEvents.Find(sportEventId);

                if (sportEvent is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.SportEvents.Remove(sportEvent);

                try
                {
                    _ = context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            MainTreeView.SelectedNode.Remove();
        }

        private void DeleteTeamById(int teamId, int sportEventId, int numberChildren)
        {
            if (numberChildren > 0)
            {
                _ = MessageBox.Show(@"Невозможно удалить запись!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                ParticipationEvent paticipationEvent = context.ParticipationEvents.Find(sportEventId, teamId);

                if (paticipationEvent is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.ParticipationEvents.Remove(paticipationEvent);

                try
                {
                    _ = context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            MainTreeView.SelectedNode.Remove();
        }

        private void DeleteAthleteById(int athleteId)
        {
            using (GreatSportEventContext context = new())
            {
                Athlete athlete = context.Athletes.Find(athleteId);

                if (athlete is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.Athletes.Remove(athlete);

                try
                {
                    _ = context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
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
            bool isEnabled = MainTreeView.SelectedNode != null;

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
            bool isEnabled = MainTreeView.SelectedNode != null;

            CreateToolStripButton.Enabled = isEnabled;
            EditToolStripButton.Enabled = isEnabled;
            DeleteToolStripButton.Enabled = isEnabled;
        }

        #endregion

        private void MainTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode != null && !currentNode.Checked)
            {
                currentNode.Nodes.Clear();
                currentNode.Checked = true;

                switch (currentNode.Level)
                {
                    case 0:
                        EnumerableRowCollection<DataRow> teams = Query.GetListTeamsBySportEvent(out bool isConnected, (int)currentNode.Tag).AsEnumerable();

                        if (!isConnected)
                        {
                            _ = MessageBox.Show(@"Отсутствует подключение!");
                            return;
                        }

                        foreach (DataRow team in teams)
                        {
                            TreeNode node = new(team["name"].ToString())
                            {
                                Tag = team["id"],
                                Checked = false
                            };

                            if (team["athletes"] is not DBNull)
                            {
                                _ = node.Nodes.Add("Temp");
                            }

                            _ = currentNode.Nodes.Add(node);
                        }
                        break;
                    case 1:
                        EnumerableRowCollection<DataRow> athletes = Query.GetListAthletesByTeam(out isConnected, (int)currentNode.Tag).AsEnumerable();

                        if (!isConnected)
                        {
                            _ = MessageBox.Show(@"Отсутствует подключение!");
                            return;
                        }

                        foreach (DataRow athlete in athletes)
                        {
                            TreeNode node = new(athlete["name"].ToString())
                            {
                                Tag = athlete["id"],
                                Checked = false
                            };
                            _ = currentNode.Nodes.Add(node);
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        private void MainTreeView_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void MainTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            _ = DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
