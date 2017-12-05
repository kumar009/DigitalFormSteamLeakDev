using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigitalFormsSteamLeak.Entity.IModels;

namespace DigitalFormsSteamLeak.Entity.Models
{
    [Table("T_Portal_Insulation_ReInstall_Session")]
    public class PortalInsulationReInstallSession : IPortalInsulationReInstallSession
    {
        [Key]
        [Column("Reinstall_Insulation_Id")]
        public Guid ReinstallInsulationId { get; set; }

        [Required]
        [Column("Reinstall_Insulation_Type")]
        public string ReinstallInsulationType { get; set; }

        [Required]
        [Column("Request_Created_Date")]
        public DateTime RequestCreatedDate { get; set; }

        [Column("Request_Start_Date")]
        public DateTime RequestStartDate { get; set; }

        [Column("Request_End_Date")]
        public DateTime RequestEndDate { get; set; }

        [Column("Request_Comment")]
        public string RequestComments { get; set; }


        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}