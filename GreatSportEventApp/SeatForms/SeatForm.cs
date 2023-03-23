using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SportEventForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GreatSportEventApp.SeatForms
{
    public partial class SeatForm : Form
    {
        private int sportEventId;

        public int SeatId { get; set; }

        public SeatForm(bool isChanging, int _seatId)
        {
            InitializeComponent();

            SeatId = _seatId;

            sportEventId = -1;

            if (isChanging)
            {
                Text = @"Изменение посадочного места";
                labelTitle.Text = @"Изменение посадочного места";
                GetSeatById();
            }
        }

        private void GetSeatById()
        {
            DataRow dataRow = Query.GetSeatById(out bool isConnected, SeatId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            sportEventId = (int)dataRow["sport_event_id"];

            textSportEventName.Text = dataRow["sport_event_name"].ToString();
            textSeatName.Text = dataRow["seat_name"].ToString();
            textPrice.Text = dataRow["seat_price"].ToString();
            checkBoxIsOccupied.Checked = (bool)dataRow["is_occupied"];
        }

        private void SelectSportEventButton_Click(object sender, EventArgs e)
        {
            ListSportEventsForm sportEventsForm = new(true);
            sportEventsForm.ShowDialog();

            var selectedEvent = sportEventsForm.SelectedItem;

            if (selectedEvent == null)
            {
                return;
            }

            sportEventId = (int)selectedEvent.Cells["id"].Value;
            textSportEventName.Text = Query.GetSportEventStringById(out _, sportEventId);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (sportEventId <= 0 || textSeatName.Text == "" || textPrice.Text == "")
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                Seat seat;

                if (SeatId == -1)
                {
                    seat = new Seat();
                    _ = context.Seats.Add(seat);
                }
                else
                {
                    seat = context.Seats.Find(SeatId);
                }

                seat.SeatName = textSeatName.Text;
                seat.SportEventId = sportEventId;

                decimal.TryParse(textPrice.Text, out decimal price);
                seat.SeatPrice = price;

                seat.IsOccupied = checkBoxIsOccupied.Checked;

                _ = context.SaveChanges();

                SeatId = seat.Id;
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