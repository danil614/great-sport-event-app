using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("login")]
        public string Login { get; set; }

        [Required]
        [Column("password")]
        public string Password { get; set; }

        [Column("access_mode")]
        public string AccessMode { get; set; }

        [Column("athlete_id")]
        public int? AthleteId { get; set; }

        [Column("employee_id")]
        public int? EmployeeId { get; set; }

        [Column("viewer_id")]
        public int? ViewerId { get; set; }

        public int GetAccessMode()
        {
            if (int.TryParse(AccessMode, out var accessMode))
            {
                return accessMode;
            }
            else
            {
                return 0;
            }
        }
    }
}
