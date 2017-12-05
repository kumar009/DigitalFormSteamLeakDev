using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface IIsolationSession
    {
        Guid LeakIsolationId { get; set; }

        string IsIsolationVerifed { get; set; }

        string ProcessOperatorName { get; set; }

        DateTime IsolationVerifiedDate { get; set; }

        string ReasonIsolationNotVerified { get; set; }





        Guid LeakDetailsId { get; set; }
    }
}