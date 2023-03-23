using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }

        [Required]
        [Column("viewer_id")]
        public int ViewerId { get; set; }

        [Column("employee_id")]
        public int? EmployeeId { get; set; }

        [Required]
        [Column("seat_id")]
        public int SeatId { get; set; }

        [Required]
        [Column("sale_date_time")]
        public DateTime SaleDateTime { get; set; }
    }
}
