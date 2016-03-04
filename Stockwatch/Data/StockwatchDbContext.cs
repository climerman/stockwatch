    using System;
using System.Collections.Generic;
using System.Data.Entity;
    using System.Diagnostics;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using Data.Migrations;
    using Domain;

namespace Data
{
    public class StockwatchDbContext : DbContext
    {
        public StockwatchDbContext() : base("StockwatchDbConnectionString")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StockwatchDbContext, MigrationConfiguration>());

#if DEBUG
            Database.Log = s => Trace.Write(s);
#endif
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Market> Markets { get; set; }

       
    }
}
