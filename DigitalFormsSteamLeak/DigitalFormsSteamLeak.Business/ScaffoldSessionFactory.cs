using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class ScaffoldSessionFactory : ILeakFactory<ScaffoldSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public ScaffoldSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(ScaffoldSession entity)
        {
            return leakDB.Save<ScaffoldSession>(entity);
        }

        public int Update(ScaffoldSession entity)
        {
            return leakDB.Update<ScaffoldSession>(entity);
        }

        public IQueryable<ScaffoldSession> GetAll()
        {
            return leakDB.GetDetails<ScaffoldSession>();
        }

        public IQueryable<ScaffoldSession> GetById(Guid? id)
        {
            return GetAll().Where(s => s.ScaffoldId == id);
        }
    }
}