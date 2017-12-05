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
    [Table("T_Malfunction_Session")]
    public class MalfunctionSession : IMalfunctionSession
    {
        [Key]
        [Column("Malfunction_Id")]
        public Guid MalfunctionId { get; set; }

        [Required]
        [Column("Malfunction_Comments")]
        public string MalfunctionComments { get; set; }

        [Required]
        [Column("Is_LokRing_Job_Required")]
        public string IsLokRingJobRequired { get; set; }

        [Required]
        [Column("Is_Break_In")]
        public string IsBreakIn { get; set; }

        [Required]
        [Column("Is_Turn_Around_Item")]
        public string IsTurnAroudItem { get; set; }

        [Required]
        [Column("Is_Down_Time_Required")]
        public string IsDownTimeRequired { get; set; }

        [Required]
        [Column("Is_Man_Lift_Required")]
        public string IsManLiftRequired { get; set; }

        [Required]
        [Column("Is_First_Time_Pump")]
        public string IsFirstTimePump { get; set; }

        [Required]
        [Column("Is_Re_Pump")]
        public string IsRePump { get; set; }

        [Required]
        [Column("Is_Install_Clamp_Required")]
        public string IsInstallClampRequired { get; set; }

        [Required]
        [Column("Is_Wire_Wrap_Required")]
        public string IsWirewrapRequired { get; set; }

        [Required]
        [Column("OnHold")]
        public string OnHold { get; set; }


        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}