using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class LocationUnitFactory : ILeakFactory<LocationUnit>
    {
        protected LeakDbHelper leakDB { get; set; }
        public LocationUnitFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(LocationUnit entity)
        {
            return leakDB.Save<LocationUnit>(entity);
        }

        public int Update(LocationUnit entity)
        {
            return leakDB.Update<LocationUnit>(entity);
        }

        public IQueryable<LocationUnit> GetAll()
        {
            return leakDB.GetDetails<LocationUnit>();
        }

        public IQueryable<LocationUnit> GetById(Guid? id)
        {
            return GetAll().Where(lu => lu.UnitId == id);
        }
    }
}