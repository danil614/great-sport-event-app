using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        [Column("team_id")]
        public int Id { get; set; }

        [Required]
        [Column("location_id")]
        public int LocationId { get; set; }

        [Required]
        [Column("team_name")]
        public string Name { get; set; }

        [Required]
        [Column("rating")]
        public int Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
