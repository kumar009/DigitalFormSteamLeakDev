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
    [Table("T_MOC_Session")]
    public class MOCSession : IMOCSession
    {
        [Key]
        [Column("MOC_Id")]
        public Guid MOCId { get; set; }

        [Required]
        [Column("MOC_Number")]
        public int MOCNumber { get; set; }

        [Required]
        [Column("MOC_Date_Requested")]
        public DateTime MOCDateRequested { get; set; }

        [Required]
        [Column("MOC_Status")]
        public string MOCStatus { get; set; }

        [Required]
        [Column("MOC_Comments")]
        public string MOCComments { get; set; }


        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}