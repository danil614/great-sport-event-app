using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatSportEventApp.Entities
{
    [Table("Organisation_events")]
    public class OrganisationEvent
    {
        [Key, Column("sport_event_id", Order = 0)]
        public int SportEventId { get; set; }

        [Key, Column("employee_id", Order = 1)]
        public int EmployeeId { get; set; }
    }
}
