﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        [Column("location_id")]
        public int Id { get; set; }

        [Required]
        [Column("location_name")]
        public string Name { get; set; }

        [Required]
        [Column("city_id")]
        public long CityId { get; set; }

        [Column("address")]
        [StringLength(maximumLength: 60)]
        public string Address { get; set; }

        [Required]
        [Column("location_type_id")]
        public int TypeId { get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("description")]
        public string Description { get; set; }

        // [Column("picture")]
        // public byte[] Picture { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Address}";
        }
    }
}
