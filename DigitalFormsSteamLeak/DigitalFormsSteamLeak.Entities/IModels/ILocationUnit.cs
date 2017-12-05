using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILocationUnit
    {
        Guid UnitId { get; set; }
        string UnitName { get; set; }

        Guid BusinessLocationId { get; set; }
    }
}