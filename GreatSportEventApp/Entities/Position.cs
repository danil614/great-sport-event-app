using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Positions")]
    public class Position
    {
        [Key, Column("position_id")]
        public long Id { get; set; }

        [Required]
        [Column("position_name")]
        public string Name { get; set; }
    }
}
