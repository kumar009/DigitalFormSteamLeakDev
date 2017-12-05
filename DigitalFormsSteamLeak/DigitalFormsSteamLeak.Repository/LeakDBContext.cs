using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Repository
{
    public class LeakDBContext : DbContext
    {
        public LeakDBContext():base("name=DbConnection")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<LeakUser> leakUser { get; set; }

        public DbSet<LeakType> leakType { get; set; }

        public DbSet<LocationDepartment> locationDepartment { get; set; }

        public DbSet<LocationBusiness> locationBusiness { get; set; }

        public DbSet<LocationUnit> locationUnit { get; set; }

        public DbSet<PortalInsulationRemoveSession> portalInsulationSession { get; set; }
    }
}
