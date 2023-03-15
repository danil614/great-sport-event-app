using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    [Table("Participation_events")]
    public class ParticipationEvent
    {
        [Key, Column("sport_event_id", Order = 0)]
        public int SportEventId { get; set; }

        [Key, Column("team_id", Order = 1)]
        public int TeamId { get; set; }

        [Column("score")]
        public int Score { get; set; }
    }
}
