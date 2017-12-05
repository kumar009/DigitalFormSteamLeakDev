using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IScaffoldSession
    {
        Guid ScaffoldId { get; set; }

        string ScaffoldType { get; set; }

        float ScaffoldWidth { get; set; }

        float ScaffoldLength { get; set; }

        float ScaffoldHeight { get; set; }

        int Legs { get; set; }

        int Decks { get; set; }

        float LGFt { get; set; }

        float FT2 { get; set; }

        int ScaffoldTagNumber { get; set; }

        int BWANumber { get; set; }

        DateTime BWARequestCreatedDate { get; set; }

        DateTime BWARequestStartDate { get; set; }

        DateTime BWARequestEndDate { get; set; }

        string BWAComments { get; set; }

        int MWANumber { get; set; }

        DateTime MWARequestCreatedDate { get; set; }

        DateTime MWARequestStartDate { get; set; }

        DateTime MWARequestEndDate { get; set; }

        string MWAComments { get; set; }

        int DWANumber { get; set; }

        DateTime DWARequestCreatedDate { get; set; }

        DateTime DWARequestStartDate { get; set; }

        DateTime DWARequestEndDate { get; set; }

        string DWAComments { get; set; }


        Guid LeakDetailsId { get; set; }
    }
}
