using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Sport_events")]
    public class SportEvent
    {
        [Key]
        [Column("sport_event_id")]
        public int Id { get; set; }

        [Required]
        [Column("location_id")]
        public int LocationId { get; set; }

        [Required]
        [Column("type_id")]
        public int TypeId { get; set; }

        [Required]
        [Column("sport_event_date_time")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [Column("duration")]
        public TimeSpan Duration { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
