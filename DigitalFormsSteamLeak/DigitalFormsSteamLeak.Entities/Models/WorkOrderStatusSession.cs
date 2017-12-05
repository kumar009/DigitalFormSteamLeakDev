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
    [Table("T_Work_Order_Status_Session")]
    public class WorkOrderStatusSession : IWorkOrderStatusSession
    {
        [Key]
        [Column("Work_Order_Status_Id")]
        public Guid WorkOrderStatusId { get; set; }

        [Required]
        [Column("Work_Done_By")]
        public string WorkDoneBy { get; set; }

        [Required]
        [Column("Work_Order_Status")]
        public string WorkOrderStatus { get; set; }

        [Required]
        [Column("Work_Order_Status_Comments")]
        public string WorkOrderStatusComments { get; set; }

        [Column("Work_Order_Completed_Date")]
        public DateTime WorkOrderCompletedDate { get; set; }

        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}