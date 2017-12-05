using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IMOCSession
    {
        Guid MOCId { get; set; }

        int MOCNumber { get; set; }

        DateTime MOCDateRequested { get; set; }

        string MOCStatus { get; set; }

        string MOCComments { get; set; }






        Guid LeakDetailsId { get; set; }

    }
}
