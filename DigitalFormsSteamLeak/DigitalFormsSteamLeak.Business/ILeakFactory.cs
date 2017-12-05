using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business
{
    public interface ILeakFactory<T> where T : class
    {
        int Create(T entity);

        int Update(T entity);

        IQueryable<T> GetById(Guid? id);

        IQueryable<T> GetAll();

        // int Delete(T entity);
    }
}