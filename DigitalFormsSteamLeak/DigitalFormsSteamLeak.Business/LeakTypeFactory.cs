using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class LeakTypeFactory : ILeakFactory<ILeakType>
    {
        protected LeakDbHelper leakDB { get; set; }

        public LeakTypeFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(ILeakType entity)
        {
            return leakDB.Save<LeakType>((LeakType)entity);
        }

        public int Update(ILeakType entity)
        {
            return leakDB.Update<LeakType>((LeakType)entity);
        }

        public IQueryable<ILeakType> GetAll()
        {
            return leakDB.GetDetails<LeakType>();
        }

        public IQueryable<ILeakType> GetById(Guid? id)
        {
            return GetAll().Where(lt => lt.LeakTypeId == id);
        }
    }
}