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
    public partial class EventsEmployeesForm : DockContent
    {
        public EventsEmployeesForm()
        {
            InitializeComponent();
            SetVisibleItems();
        }


        private void SetVisibleItems()
        {
            if (MainForm.CurrentUser.UserType == UserType.Admin)
            {
                DeleteToolStripButton.Visible = true;
                toolStripSeparator4.Visible = true;

                DeleteToolStripMenuItem.Visible = true;
            }
            else
            {
                DeleteToolStripButton.Visible = false;
                toolStripSeparator4.Visible = false;

                DeleteToolStripMenuItem.Visible = false;
            }
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            MainTreeView.Nodes.Clear();
            EnumerableRowCollection<DataRow> sportEvents = Query.GetListSportEventsEmployees(out bool isConnected).AsEnumerable();

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

                if (sportEvent["employees"] is not DBNull)
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
                        // Создаем сотрудника для организации спортивного мероприятия
                        CreateEmployee();
                        break;
                    default:
                        break;
                }
            }
        }

        private void CreateEmployee()
        {
            TreeNode currentNode = MainTreeView.SelectedNode;

            ListEmployeesForm employeesForm = new(true);
            employeesForm.ShowDialog();

            if (employeesForm.SelectedItem == null)
            {
                MessageBox.Show(@"Команда не выбрана!");
                return;
            }

            var employeeId = (int)employeesForm.SelectedItem.Cells[0].Value;
            var sportEventId = (int)currentNode.Tag;

            if (employeeId > 0 && sportEventId > 0)
            {
                bool isEmployeeNew;

                // Добавляем во вспомогательную таблицу
                using (GreatSportEventContext context = new())
                {
                    isEmployeeNew = UpdateOrganisationEvent(context, sportEventId, employeeId);
                }

                if (isEmployeeNew)
                {
                    var employeeString = Query.GetEmployeeStringById(out bool isConnected, employeeId);

                    if (!isConnected)
                    {
                        MessageBox.Show(@"Отсутствует подключение!");
                        return;
                    }

                    TreeNode node = new(employeeString)
                    {
                        Tag = employeeId,
                        Checked = false
                    };

                    currentNode.Nodes.Add(node);
                }
            }
        }

        private static bool UpdateOrganisationEvent(GreatSportEventContext context, int sportEventId, int employeeId)
        {
            bool isNew = false;

            OrganisationEvent organisationEvent = context.OrganisationEvents.Find(sportEventId, employeeId);
            if (organisationEvent is null)
            {
                isNew = true;

                organisationEvent = new OrganisationEvent();
                organisationEvent.SportEventId = sportEventId;
                organisationEvent.EmployeeId = employeeId;

                _ = context.OrganisationEvents.Add(organisationEvent);
            }

            _ = context.SaveChanges();

            return isNew;
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
                        // Изменяем сотрудника
                        EmployeeForm employeeForm = new(true, (int)currentNode.Tag);
                        _ = employeeForm.ShowDialog();
                        if (employeeForm.EmployeeString != "")
                        {
                            currentNode.Text = employeeForm.EmployeeString;
                        }

                        break;
                    default:
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
                        // Удаляем сотрудника
                        DeleteEmployeeById((int)currentNode.Parent.Tag, (int)currentNode.Tag);
                        break;
                    default:
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

        private void DeleteEmployeeById(int sportEventId, int employeeId)
        {
            using (GreatSportEventContext context = new())
            {
                var organisationEvent = context.OrganisationEvents.Find(sportEventId, employeeId);

                if (organisationEvent is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.OrganisationEvents.Remove(organisationEvent);

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

            CreateToolStripMenuItem.Enabled = isEnabled && MainTreeView.SelectedNode.Level == 0;
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
                        // Раскрываем спортивное мероприятие
                        EnumerableRowCollection<DataRow> employees = Query.GetListEmployeesBySportEvent(out bool isConnected, (int)currentNode.Tag).AsEnumerable();

                        if (!isConnected)
                        {
                            _ = MessageBox.Show(@"Отсутствует подключение!");
                            return;
                        }

                        foreach (DataRow employee in employees)
                        {
                            TreeNode node = new(employee["name"].ToString())
                            {
                                Tag = employee["id"],
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
