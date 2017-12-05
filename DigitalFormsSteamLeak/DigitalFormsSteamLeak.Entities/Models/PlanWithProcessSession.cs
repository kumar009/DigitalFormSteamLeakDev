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
    [Table("T_Plan_With_Process_Session")]
    public class PlanWithProcessSession : IPlanWithProcessSession
    {
        [Key]
        [Column("Plan_With_Process_Id")]
        public Guid PlanWithProcessId { get; set; }

        [Required]
        [Column("Process_Start_Date")]
        public DateTime ProcessStartDate { get; set; }

        [Required]
        [Column("Operator_Name")]
        public string OperatorName { get; set; }

        [Required]
        [Column("Plan_With_Process_Comments")]
        public string PlanWithProcessComments { get; set; }

        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }

    }
}