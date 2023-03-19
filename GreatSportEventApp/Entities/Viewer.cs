using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Viewers")]
    public class Viewer
    {
        [Key]
        [Column("viewer_id")]
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
        public DateTime BirthDate { get; set; }

        [Required]
        [Column("number_purchases")]
        public int NumberPurchases { get; set; }
    }
}
