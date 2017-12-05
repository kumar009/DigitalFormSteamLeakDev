using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class LeakDetailsFactory : ILeakFactory<LeakDetails>
    {
        protected LeakDbHelper leakDB { get; set; }
        public LeakDetailsFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(LeakDetails entity)
        {
            return leakDB.Save<LeakDetails>(entity);
        }

        public int Update(LeakDetails entity)
        {
            return leakDB.Update<LeakDetails>(entity);
        }

        public IQueryable<LeakDetails> GetAll()
        {
            return leakDB.GetDetails<LeakDetails>();
        }

        public IQueryable<LeakDetails> GetById(Guid? id)
        {
            return GetAll().Where(ld => ld.LeakDetailsId == id);
        }
    }
}