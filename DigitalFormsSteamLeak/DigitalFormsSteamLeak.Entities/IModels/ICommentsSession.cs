using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.IModels
{
    public interface ICommentsSession
    {
        Guid CommentsId { get; set; }

        string CommentNotes { get; set; }

        string CommenterName { get; set; }

        DateTime DateCommented { get; set; }



        Guid LeakDetailsId { get; set; }
    }
}