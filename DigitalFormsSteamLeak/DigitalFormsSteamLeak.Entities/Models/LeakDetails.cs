using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;

namespace DigitalFormsSteamLeak.Entity.Models
{
    [Table("T_Leak_Details")]
    public class LeakDetails : ILeakDetails
    {
        [Key]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        [Column("User_Id")]
        public Guid UserId { get; set; }

        [Column("Unit_Id")]
        public Guid UnitId { get; set; }
        [Column("Leak_Type_Id")]
        public Guid LeakTypeId { get; set; }

        [Required]
        [Column("Leak_Number")]
        public int LeakNumber { get; set; }

        [Required]
        [Column("Scooped_Date")]
        public DateTime ScoopedDate { get; set; }

        [Required]
        [Column("Notification_Number")]
        public int NotificationNumber { get; set; }

        [Required]
        [Column("Date_Notification_Received")]
        public DateTime DateNotificationReceived { get; set; }

        [Required]
        [Column("Work_Order_Number")]
        public int WorkOrderNumber { get; set; }

        [Required]
        [Column("Date_Work_Order_Received")]
        public DateTime DateWorkOrderReceived { get; set; }

        [Required]
        [Column("Work_Order_Description")]
        public string WorkOrderDescription { get; set; }

        [Required]
        [Column("SST_Description")]
        public string SSTDescription { get; set; }

        [Required]
        [Column("Identified_By")]
        public string IdentifiedBy { get; set; }

        [Required]
        [Column("Decible_reading")]
        public float DecibelReading { get; set; }

        [Required]
        [Column("Height_From_Grade")]
        public float HeightFromGrade { get; set; }

        [Required]
        [Column("Height_From_Leak")]
        public float HeightFromLeak { get; set; }

        [Required]
        [Column("Existing_Hearing_Protection")]
        public string ExistingHearingProtection { get; set; }

        [Required]
        [Column("Populate")]
        public string Populate { get; set; }

        [Required]
        [Column("Plume_Size")]
        public float PlumeSize { get; set; }

        [Required]
        [Column("Temperature")]
        public float Temperature { get; set; }

        [Required]
        [Column("Orifice_Size")]
        public float OrificeSize { get; set; }

        [Required]
        [Column("LOC_Reading")]
        public float LOCReading { get; set; }

        [Required]
        [Column("LOC_Rate")]
        public float LOCRate { get; set; }

        [Required]
        [Column("Is_Plan_With_Process_Required")]
        public string IsPlanWithProcessReqired { get; set; }

        [Required]
        [Column("Is_FEWA_Required")]
        public string IsFEWARequired { get; set; }

        //[Required]
        //[Column("Is_Attach2_Required")]
        //public string IsAttach2Required { get; set; }

        [Required]
        [Column("Is_MOC_Required")]
        public string IsMOCRequired { get; set; }

        [Required]
        [Column("Is_Remove_Insulation_Required")]
        public string IsRemoveInsulationRequired { get; set; }

        [Required]
        [Column("Is_Reinstall_Insulation_Required")]
        public string IsReinstallInsulationRequired { get; set; }

        [Required]
        [Column("Is_ReScope_Required")]
        public string IsReScopeRequired { get; set; }

        [Required]
        [Column("Job_Pack_Status")]
        public string JobPackStatus { get; set; }

        [Required]
        [Column("Leak_Status")]
        public string LeakStatus { get; set; }

        [Required]
        [Column("Leak_Comments")]
        public string LeakComments { get; set; }


        public virtual LeakUser LeakUser { get; set; }

        public virtual LocationUnit Unit { get; set; }

        public virtual LeakType Leaktype { get; set; }

        //public virtual ICollection<IsolationSession> Isolation { get; set; }

        //public virtual ICollection<MalfunctionSession> Malfunction { get; set; }

        //public virtual ICollection<ScaffoldSession> scaffold { get; set; }

        //public virtual ICollection<PortalInsulationRemoveSession> Remove { get; set; }

        //public virtual ICollection<PortalInsulationReInstallSession> ReInstall { get; set; }

        //public virtual ICollection<CommentsSession> Comments { get; set; }

        //public virtual ICollection<MOCSession> MOC { get; set; }

        //public virtual ICollection<PlanWithProcessSession> Plan { get; set; }

        //public virtual ICollection<WorkOrderStatusSession> WorkOrder { get; set; }

    }
}