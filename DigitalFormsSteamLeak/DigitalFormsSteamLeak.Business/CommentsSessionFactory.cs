using DigitalFormsSteamLeak.Entity.Models;
using DigitalFormsSteamLeak.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public class CommentsSessionFactory
    {
        protected LeakDbHelper leakDB { get; set; }
        public CommentsSessionFactory()
        {
            leakDB = new LeakDbHelper();
        }

        public int Create(CommentsSession entity)
        {
            return leakDB.Save<CommentsSession>(entity);
        }

        public int Update(CommentsSession entity)
        {
            return leakDB.Update<CommentsSession>(entity);
        }

        public IQueryable<CommentsSession> GetAll()
        {
            return leakDB.GetDetails<CommentsSession>();
        }

        public IQueryable<CommentsSession> GetById(Guid? id)
        {
            return GetAll().Where(c => c.CommentsId == id);
        }
    }
}