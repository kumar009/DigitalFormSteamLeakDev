using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILocationDepartment
    {
        Guid DepartmentId { get; set; }

        string DepatmentName { get; set; }
    }
}