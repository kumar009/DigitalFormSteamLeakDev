using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class PortalInsulationRemoveSessionFactory : ILeakFactory<PortalInsulationRemoveSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public PortalInsulationRemoveSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(PortalInsulationRemoveSession entity)
        {
            return leakDB.Save<PortalInsulationRemoveSession>(entity);
        }

        public int Update(PortalInsulationRemoveSession entity)
        {
            return leakDB.Update<PortalInsulationRemoveSession>(entity);
        }

        public IQueryable<PortalInsulationRemoveSession> GetAll()
        {
            return leakDB.GetDetails<PortalInsulationRemoveSession>();
        }

        public IQueryable<PortalInsulationRemoveSession> GetById(Guid? id)
        {
            return GetAll().Where(i => i.RemoveInsulationId == id);
        }
    }
}
