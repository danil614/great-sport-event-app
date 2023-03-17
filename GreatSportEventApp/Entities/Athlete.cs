using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Athletes")]
    public class Athlete
    {
        [Key]
        [Column("athlete_id")]
        public int Id { get; set; }

        [Required]
        [Column("surname")]
        public string Surname { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Column("patronymic")]
        public string Patronymic { get; set; }

        [Required]
        [Column("gender_id")]
        public int GenderId { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column("birth_date")]
        [DataType(DataType.Date)]
        public DateTime BithDate { get; set; }

        [Required]
        [Column("team_id")]
        public int TeamId { get; set; }

        [Required]
        [Column("position_id")]
        public int PositionId { get; set; }

        [Column("rating")]
        public int? Rating { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
