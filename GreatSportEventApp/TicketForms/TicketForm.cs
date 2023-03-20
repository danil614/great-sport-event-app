using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GreatSportEventApp.TicketForms
{
    public partial class TicketForm : Form
    {
        private int viewerId;
        private int? employeeId;

        public int TicketId { get; set; }

        public TicketForm(bool isChanging, int _ticketId)
        {
            InitializeComponent();

            TicketId = _ticketId;

            viewerId = -1;
            employeeId = MainForm.CurrentUser.EmployeeId;

            if (isChanging)
            {
                Text = @"Изменение билета";
                labelTitle.Text = @"Изменение билета";
                GetTicketById();
            }

            saleDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        private void GetTicketById()
        {
            using (GreatSportEventContext context = new())
            {
                var ticket = context.Tickets.Find(TicketId);

                if (ticket is null)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                viewerId = ticket.ViewerId;
                employeeId = ticket.EmployeeId;

                var employee = context.Employees.Find(employeeId);
                textEmployeeName.Text = employee is null ? "" : employee.ToString();

                textViewerName.Text = context.Viewers.Find(viewerId).ToString();
                saleDateTime.Value = ticket.SaleDateTime;
                textSeat.Text = ticket.SeatName;
                textPrice.Text = ticket.Price.ToString();
            }
        }

        private void SelectViewerButton_Click(object sender, EventArgs e)
        {
            ListViewersForm viewersForm = new(true);
            viewersForm.ShowDialog();

            var selectedViewer = viewersForm.SelectedItem;

            if (selectedViewer == null)
            {
                return;
            }

            viewerId = (int)selectedViewer.Cells["Номер"].Value;
            textViewerName.Text = selectedViewer.Cells["ФИО"].Value.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (viewerId <= 0 || textSeat.Text == "" || textPrice.Text == "")
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                Ticket ticket;

                if (TicketId == -1) // При создании новой команды
                {
                    ticket = new Ticket();
                    ticket.SaleDateTime = DateTime.Now;
                    _ = context.Tickets.Add(ticket);
                }
                else
                {
                    ticket = context.Tickets.Find(TicketId);
                }

                ticket.ViewerId = viewerId;
                ticket.EmployeeId = employeeId > 0 ? employeeId : null;
                ticket.SeatName = textSeat.Text;

                _ = decimal.TryParse(textPrice.Text, out decimal price);
                ticket.Price = price;

                _ = context.SaveChanges();

                TicketId = ticket.Id;
            }

            Close();
        }

        #region Validating

        private void TextSeat_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 10);
        }

        private void TextPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetDecimalError(sender, errorProvider1);
        }

        #endregion
    }
}