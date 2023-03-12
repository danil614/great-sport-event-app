using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Column("sport_event_date_time")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [Column("duration")]
        [DataType(DataType.DateTime)]
        public DateTime Duration { get; set; }

        [NotMapped]
        [Column("description")]
        [StringLength(maximumLength: 200)]
        public string Description { get; set; }

        [NotMapped]
        [Column("location_name")]
        public string LocationName { get; set; }

        [NotMapped]
        [Column("city_name")]
        public string CityName { get; set; }

        public override string ToString()
        {
            return $"{CityName}, {LocationName}, начало: {DateTime:dd.MM.yyyy HH:mm}, длительность: {Duration.ToShortTimeString()}";
        }
    }
}
