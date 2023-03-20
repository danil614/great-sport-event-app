using MySql.Data.EntityFramework;
using System;
using System.Data.Common;
using System.Data.Entity;

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

        public DbSet<Location> Locations { get; set; }

        public DbSet<Viewer> Viewers { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }

        public GreatSportEventContext(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {
            Database.SetInitializer(new Initializer());
            Database.Log = Console.Write;
        }

        public GreatSportEventContext()
               : base(connectionString)
        {
            Database.SetInitializer(new Initializer());
            Database.Log = Console.Write;
        }
    }

    public class Initializer : IDatabaseInitializer<GreatSportEventContext>
    {
        public void InitializeDatabase(GreatSportEventContext context)
        {
        }
    }
}
