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

        public DbSet<City> Cities { get; set; }

        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Position> Positions { get; set; }

        public GreatSportEventContext(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {
            Database.SetInitializer(new Initializer());
            Database.Log = delegate (string message) { Console.Write(message); };
        }

        public GreatSportEventContext()
               : base(connectionString)
        {
            Database.SetInitializer(new Initializer());
            Database.Log = delegate (string message) { Console.Write(message); };
        }
    }

    public class Initializer : IDatabaseInitializer<GreatSportEventContext>
    {
        public void InitializeDatabase(GreatSportEventContext context)
        {
        }
    }
}
