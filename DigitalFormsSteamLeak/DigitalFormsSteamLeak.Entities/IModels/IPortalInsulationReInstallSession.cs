using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IPortalInsulationReInstallSession
    {
        Guid ReinstallInsulationId { get; set; }

        string ReinstallInsulationType { get; set; }

        DateTime RequestCreatedDate { get; set; }

        DateTime RequestStartDate { get; set; }

        DateTime RequestEndDate { get; set; }

        string RequestComments { get; set; }







        Guid LeakDetailsId { get; set; }
    }
}