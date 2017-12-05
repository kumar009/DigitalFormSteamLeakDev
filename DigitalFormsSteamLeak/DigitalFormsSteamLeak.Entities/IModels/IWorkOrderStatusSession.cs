using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IWorkOrderStatusSession
    {
        Guid WorkOrderStatusId { get; set; }

        string WorkDoneBy { get; set; }

        string WorkOrderStatus { get; set; }

        string WorkOrderStatusComments { get; set; }

        DateTime WorkOrderCompletedDate { get; set; }



        Guid LeakDetailsId { get; set; }
    }
}
