using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
