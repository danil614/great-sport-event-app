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
        private int seatId;

        public int TicketId { get; set; }

        public TicketForm(bool isChanging, int _ticketId)
        {
            InitializeComponent();

            TicketId = _ticketId;

            viewerId = -1;
            employeeId = MainForm.CurrentUser.EmployeeId;
            seatId = -1;

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
            DataRow dataRow = Query.GetTicketById(out bool isConnected, TicketId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            viewerId = (int)dataRow["viewer_id"];
            employeeId = dataRow["employee_id"] is DBNull ? null : (int)dataRow["employee_id"];
            seatId = (int)dataRow["seat_id"];

            textViewerName.Text = dataRow["viewer_name"].ToString();
            textEmployeeName.Text = dataRow["employee_name"].ToString();
            textSportEventName.Text = dataRow["sport_event_name"].ToString();
            saleDateTime.Value = (DateTime)dataRow["sale_date_time"];
            textSeat.Text = dataRow["seat"].ToString();
            textPrice.Text = dataRow["price"].ToString();
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

        private void SelectSeatButton_Click(object sender, EventArgs e)
        {

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
                ticket.SeatId = seatId;

                _ = context.SaveChanges();

                TicketId = ticket.Id;
            }

            DialogResult = DialogResult.OK;
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