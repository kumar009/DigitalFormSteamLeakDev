using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILeakType
    {
        Guid LeakTypeId { get; set; }


        string LeakTypeName { get; set; }

    }
}