using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IMalfunctionSession
    {
        Guid MalfunctionId { get; set; }

        string MalfunctionComments { get; set; }

        string IsLokRingJobRequired { get; set; }

        string IsBreakIn { get; set; }

        string IsTurnAroudItem { get; set; }

        string IsDownTimeRequired { get; set; }

        string IsManLiftRequired { get; set; }

        string IsFirstTimePump { get; set; }

        string IsRePump { get; set; }

        string IsInstallClampRequired { get; set; }

        string IsWirewrapRequired { get; set; }

        string OnHold { get; set; }






        Guid LeakDetailsId { get; set; }
    }
}