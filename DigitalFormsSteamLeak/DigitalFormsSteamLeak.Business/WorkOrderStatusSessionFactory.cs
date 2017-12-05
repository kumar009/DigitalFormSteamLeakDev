using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class WorkOrderStatusSessionFactory : ILeakFactory<WorkOrderStatusSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public WorkOrderStatusSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(WorkOrderStatusSession entity)
        {
            return leakDB.Save<WorkOrderStatusSession>(entity);
        }

        public int Update(WorkOrderStatusSession entity)
        {
            return leakDB.Update<WorkOrderStatusSession>(entity);
        }

        public IQueryable<WorkOrderStatusSession> GetAll()
        {
            return leakDB.GetDetails<WorkOrderStatusSession>();
        }

        public IQueryable<WorkOrderStatusSession> GetById(Guid? id)
        {
            return GetAll().Where(w => w.WorkOrderStatusId == id);
        }
    }
}
