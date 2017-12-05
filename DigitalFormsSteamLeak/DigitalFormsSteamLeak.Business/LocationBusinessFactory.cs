using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class LocationBusinessFactory : ILeakFactory<LocationBusiness>
    {
        protected LeakDbHelper leakDB { get; set; }
        public LocationBusinessFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(LocationBusiness entity)
        {
            return leakDB.Save<LocationBusiness>(entity);
        }

        public int Update(LocationBusiness entity)
        {
            return leakDB.Update<LocationBusiness>(entity);
        }

        public IQueryable<LocationBusiness> GetAll()
        {
            return leakDB.GetDetails<LocationBusiness>();
        }

        public IQueryable<LocationBusiness> GetById(Guid? id)
        {
            return GetAll().Where(b => b.BusinessLocationId == id);
        }
    }
}