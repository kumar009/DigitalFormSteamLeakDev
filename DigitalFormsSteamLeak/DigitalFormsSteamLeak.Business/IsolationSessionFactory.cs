using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class IsolationSessionFactory : ILeakFactory<IsolationSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public IsolationSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(IsolationSession entity)
        {
            return leakDB.Save<IsolationSession>(entity);
        }

        public int Update(IsolationSession entity)
        {
            return leakDB.Update<IsolationSession>(entity);
        }

        public IQueryable<IsolationSession> GetAll()
        {
            return leakDB.GetDetails<IsolationSession>();
        }

        public IQueryable<IsolationSession> GetById(Guid? id)
        {
            return GetAll().Where(li => li.LeakIsolationId == id);
        }
    }
}