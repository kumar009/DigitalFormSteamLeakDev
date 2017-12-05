using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class LeakUserFactory : ILeakFactory<LeakUser>
    {
        protected LeakDbHelper leakDB { get; set; }

        public LeakUserFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(LeakUser entity)
        {
            return leakDB.Save<LeakUser>(entity);
        }

        public int Update(LeakUser entity)
        {
            return leakDB.Update<LeakUser>(entity);
        }

        public IQueryable<LeakUser> GetAll()
        {
            return leakDB.GetDetails<LeakUser>();
        }

        public IQueryable<LeakUser> GetById(Guid? id)
        {
            return GetAll().Where(lu => lu.UserId == id);
        }
    }
}