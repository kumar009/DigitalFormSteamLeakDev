using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalFormsSteamLeak.Repository;
using DigitalFormsSteamLeak.Entity.Models;

namespace DigitalFormsSteamLeak.Business
{
    public class LocationDepartmentFactory : ILeakFactory<LocationDepartment>
    {
        protected LeakDbHelper leakDB { get; set; }

        public LocationDepartmentFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(LocationDepartment Department)
        {
            return leakDB.Save<LocationDepartment>(Department);
        }

        public int Update(LocationDepartment Department)
        {
            return leakDB.Update(Department);
        }

        public IQueryable<LocationDepartment> GetAll()
        {
            return leakDB.GetDetails<LocationDepartment>();
        }

        public IQueryable<LocationDepartment> GetById(Guid? id)
        {
            return GetAll().Where(d => d.DepartmentId == id);
        }
    }
}