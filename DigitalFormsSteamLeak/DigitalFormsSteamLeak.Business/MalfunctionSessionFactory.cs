using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class MalfunctionSessionFactory : ILeakFactory<MalfunctionSession>
    {
        protected LeakDbHelper leakDB { get; set; }
        public MalfunctionSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(MalfunctionSession entity)
        {
            return leakDB.Save<MalfunctionSession>(entity);
        }

        public int Update(MalfunctionSession entity)
        {
            return leakDB.Update<MalfunctionSession>(entity);
        }

        public IQueryable<MalfunctionSession> GetAll()
        {
            return leakDB.GetDetails<MalfunctionSession>();
        }

        public IQueryable<MalfunctionSession> GetById(Guid? id)
        {
            return GetAll().Where(m => m.MalfunctionId == id);
        }
    }
}