using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class PlanWithProcessSessionFactory : ILeakFactory<PlanWithProcessSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public PlanWithProcessSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(PlanWithProcessSession entity)
        {
            return leakDB.Save<PlanWithProcessSession>(entity);
        }

        public int Update(PlanWithProcessSession entity)
        {
            return leakDB.Update<PlanWithProcessSession>(entity);
        }

        public IQueryable<PlanWithProcessSession> GetAll()
        {
            return leakDB.GetDetails<PlanWithProcessSession>();
        }

        public IQueryable<PlanWithProcessSession> GetById(Guid? id)
        {
            return GetAll().Where(p => p.PlanWithProcessId == id);
        }
    }
}