using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Types")]
    public class Type
    {
        [Key, Column("type_id")]
        public long Id { get; set; }

        [Required]
        [Column("type_name")]
        public string Name { get; set; }
    }
}
