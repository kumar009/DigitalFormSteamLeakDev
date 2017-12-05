using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Repository
{
    public class LeakDbHelper
    {

        protected LeakDBContext dbcontext { get; set; }

        public LeakDbHelper()
        {
            dbcontext = new LeakDBContext();
        }

        public IQueryable<T> GetDetails<T>() where T : class
        {
            return dbcontext.Set<T>().AsQueryable<T>();
        }
        
        public int Save<T>(T entity) where T : class
        {
            dbcontext.Set<T>().Add(entity);
            return dbcontext.SaveChanges();
        }

        public int Update<T>(T entity) where T : class
        {
            dbcontext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return dbcontext.SaveChanges();
        }
    }
}
