using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Seats")]
    public class Seat
    {
        [Key]
        [Column("seat_id")]
        public int Id { get; set; }

        [Required]
        [Column("seat_name")]
        public string SeatName { get; set; }

        [Column("sport_event_id")]
        public int SportEventId { get; set; }

        [Required]
        [Column("seat_price")]
        public decimal SeatPrice{ get; set; }

        [Required]
        [Column("is_occupied")]
        public bool IsOccupied { get; set; }
    }
}
