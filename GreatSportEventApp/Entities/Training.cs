using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Trainings")]
    public class Training
    {
        [Key]
        [Column("training_id")]
        public int Id { get; set; }

        [Required]
        [Column("location_id")]
        public int LocationId { get; set; }

        [Required]
        [Column("team_id")]
        public int TeamId { get; set; }

        [Required]
        [Column("training_date_time")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [Column("duration")]
        public TimeSpan Duration { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
