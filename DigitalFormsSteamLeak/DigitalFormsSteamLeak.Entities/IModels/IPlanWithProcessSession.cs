using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IPlanWithProcessSession
    {
        Guid PlanWithProcessId { get; set; }

        DateTime ProcessStartDate { get; set; }

        string OperatorName { get; set; }

        string PlanWithProcessComments { get; set; }






        Guid LeakDetailsId { get; set; }

    }
}