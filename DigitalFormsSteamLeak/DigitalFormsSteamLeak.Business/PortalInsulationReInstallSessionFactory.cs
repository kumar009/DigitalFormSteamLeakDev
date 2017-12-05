using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class PortalInsulationReInstallSessionFactory : ILeakFactory<PortalInsulationReInstallSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public PortalInsulationReInstallSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(PortalInsulationReInstallSession entity)
        {
            return leakDB.Save<PortalInsulationReInstallSession>(entity);
        }

        public int Update(PortalInsulationReInstallSession entity)
        {
            return leakDB.Update<PortalInsulationReInstallSession>(entity);
        }

        public IQueryable<PortalInsulationReInstallSession> GetAll()
        {
            return leakDB.GetDetails<PortalInsulationReInstallSession>();
        }

        public IQueryable<PortalInsulationReInstallSession> GetById(Guid? id)
        {
            return GetAll().Where(i => i.ReinstallInsulationId == id);
        }
    }
}