using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILocationBusiness
    {
        Guid BusinessLocationId { get; set; }


        string BusinessName { get; set; }

        Guid DepartmentId { get; set; }
    }
}