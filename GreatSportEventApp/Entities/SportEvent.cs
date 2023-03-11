using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    public class SportEvent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Duration { get; set; }

        [StringLength(maximumLength: 200)]
        public string Description { get; set; }
    }
}
