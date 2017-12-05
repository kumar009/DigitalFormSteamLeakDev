using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IPortalInsulationRemoveSession
    {
        Guid RemoveInsulationId { get; set; }

        string RemovingType { get; set; }

        decimal Temperature { get; set; }

        decimal PipeDiameter { get; set; }

        int LinearFt { get; set; }

        string Fittings { get; set; }

        string AdditionalComments { get; set; }

        DateTime RequestCreatedDate { get; set; }

        DateTime RequestStartDate { get; set; }

        DateTime RequestEndDate { get; set; }

        string RequestComments { get; set; }




        Guid LeakDetailsId { get; set; }
    }
}
