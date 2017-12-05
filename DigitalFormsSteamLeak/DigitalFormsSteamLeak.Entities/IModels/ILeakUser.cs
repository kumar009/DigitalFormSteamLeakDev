using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILeakUser
    {
        Guid UserId { get; set; }
        string UserName { get; set; }
    }
}
