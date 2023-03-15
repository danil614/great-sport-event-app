using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GreatSportEventContext : DbContext
    {
        private static readonly string connectionString = DatabaseConnection.GetConnectionString();

        public DbSet<SportEvent> SportEvents { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<ParticipationEvent> ParticipationEvents { get; set; }

        public GreatSportEventContext(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {
            Database.Log = delegate (string message) { Console.Write(message); };
        }

        public GreatSportEventContext()
               : base(connectionString)
        {
            Database.Log = delegate (string message) { Console.Write(message); };
        }
    }
}
