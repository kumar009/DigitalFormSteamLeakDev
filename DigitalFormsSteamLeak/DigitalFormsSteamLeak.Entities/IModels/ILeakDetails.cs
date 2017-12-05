using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ILeakDetails
    {
        Guid LeakDetailsId { get; set; }

        Guid UserId { get; set; }

        Guid LeakTypeId { get; set; }

        Guid UnitId { get; set; }

        int LeakNumber { get; set; }

        DateTime ScoopedDate { get; set; }

        int NotificationNumber { get; set; }

        DateTime DateNotificationReceived { get; set; }

        int WorkOrderNumber { get; set; }

        DateTime DateWorkOrderReceived { get; set; }

        string WorkOrderDescription { get; set; }

        string SSTDescription { get; set; }

        string IdentifiedBy { get; set; }

        float DecibelReading { get; set; }

        float HeightFromGrade { get; set; }

        float HeightFromLeak { get; set; }

        string ExistingHearingProtection { get; set; }

        string Populate { get; set; }

        float PlumeSize { get; set; }

        float Temperature { get; set; }

        float OrificeSize { get; set; }

        float LOCReading { get; set; }

        float LOCRate { get; set; }

        string IsPlanWithProcessReqired { get; set; }
        string IsFEWARequired { get; set; }
        //string IsAttach2Required { get; set; }
        
        string IsMOCRequired { get; set; }
        string IsRemoveInsulationRequired { get; set; }
        
        string IsReinstallInsulationRequired { get; set; }
        string IsReScopeRequired { get; set; }

        string JobPackStatus { get; set; }

        string LeakStatus { get; set; }

        string LeakComments { get; set; }


    }
}