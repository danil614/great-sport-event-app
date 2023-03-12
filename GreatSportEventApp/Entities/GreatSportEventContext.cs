using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSportEventApp.Entities
{
    class GreatSportEventContext : DbContext
    {
        public DbSet<SportEvent> SportEvents { get; set; }

        public GreatSportEventContext(DbConnection existingConnection, bool contextOwnsConnection)
               : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
