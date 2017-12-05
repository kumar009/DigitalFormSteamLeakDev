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
    [Table("T_Portal_Insulation_Remove_Session")]
    public class PortalInsulationRemoveSession : IPortalInsulationRemoveSession
    {
        [Key]
        [Column("Remove_Insulation_Id")]
        public Guid RemoveInsulationId { get; set; }

        [Required]
        [Column("Removeing_Type")]
        public string RemovingType { get; set; }

        [Required]
        [Column("Temperature")]
        public decimal Temperature { get; set; }

        [Required]
        [Column("Pipe_Diameter")]
        public decimal PipeDiameter { get; set; }

        [Required]
        [Column("LinearFt")]
        public int LinearFt { get; set; }

        [Required]
        [Column("Fittings")]
        public string Fittings { get; set; }

        [Required]
        [Column("Additional_Comments")]
        public string AdditionalComments { get; set; }

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
