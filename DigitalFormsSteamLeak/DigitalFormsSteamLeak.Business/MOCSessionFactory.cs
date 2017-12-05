using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class MOCSessionFactory : ILeakFactory<MOCSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public MOCSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(MOCSession entity)
        {
            return leakDB.Save<MOCSession>(entity);
        }

        public int Update(MOCSession entity)
        {
            return leakDB.Update<MOCSession>(entity);
        }

        public IQueryable<MOCSession> GetAll()
        {
            return leakDB.GetDetails<MOCSession>();
        }

        public IQueryable<MOCSession> GetById(Guid? id)
        {
            return GetAll().Where(m => m.MOCId == id);
        }
    }
}
