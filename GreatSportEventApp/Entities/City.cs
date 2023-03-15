using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    [Table("Cities")]
    public class City
    {
        [Key, Column("city_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column("city_name")]
        public string Name { get; set; }
    }
}
