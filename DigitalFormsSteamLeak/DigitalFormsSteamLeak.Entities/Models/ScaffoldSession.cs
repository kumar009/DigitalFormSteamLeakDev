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
    [Table("T_Scaffold_Session")]
    public class ScaffoldSession : IScaffoldSession
    {
        [Key]
        [Column("Scaffold_Id")]
        public Guid ScaffoldId { get; set; }

        [Required]
        [Column("Scaffold_Type")]
        public string ScaffoldType { get; set; }

        [Required]
        [Column("Scaffold_Width")]
        public float ScaffoldWidth { get; set; }

        [Required]
        [Column("Scaffold_Length")]
        public float ScaffoldLength { get; set; }

        [Required]
        [Column("Scaffold_Height")]
        public float ScaffoldHeight { get; set; }

        [Required]
        [Column("Legs")]
        public int Legs { get; set; }

        [Required]
        [Column("Decks")]
        public int Decks { get; set; }

        [Column("LGFt")]
        public float LGFt { get; set; }

        [Column("FT2")]
        public float FT2 { get; set; }

        [Column("Scaffold_Tag_Number")]
        public int ScaffoldTagNumber { get; set; }

        [Column("BWA_Number")]
        public int BWANumber { get; set; }

        [Column("BWA_Request_Created_Date")]
        public DateTime BWARequestCreatedDate { get; set; }

        [Column("BWA_Request_Start_Date")]
        public DateTime BWARequestStartDate { get; set; }

        [Column("BWA_Request_End_Date")]
        public DateTime BWARequestEndDate { get; set; }

        [Column("BWA_Comments")]
        public string BWAComments { get; set; }

        [Column("MWA_Number")]
        public int MWANumber { get; set; }

        [Column("MWA_Request_Created_Date")]
        public DateTime MWARequestCreatedDate { get; set; }

        [Column("MWA_Request_Start_Date")]
        public DateTime MWARequestStartDate { get; set; }

        [Column("MWA_Request_End_Date")]
        public DateTime MWARequestEndDate { get; set; }

        [Column("MWA_Comments")]
        public string MWAComments { get; set; }

        [Column("DWA_Number")]
        public int DWANumber { get; set; }

        [Column("DWA_Request_Created_Date")]
        public DateTime DWARequestCreatedDate { get; set; }

        [Column("DWA_Request_Start_Date")]
        public DateTime DWARequestStartDate { get; set; }

        [Column("DWA_Request_End_Date")]
        public DateTime DWARequestEndDate { get; set; }

        [Column("DWA_Comments")]
        public string DWAComments { get; set; }


        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}