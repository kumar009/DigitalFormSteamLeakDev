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
    [Table("T_Isolation_Session")]
    public class IsolationSession : IIsolationSession
    {
        [Key]
        [Column("Leak_Isolation_Id")]
        public Guid LeakIsolationId { get; set; }

        [Required]
        [Column("Is_Isolation_Verified")]
        public string IsIsolationVerifed { get; set; }

        [Column("Process_Operator_Name")]
        public string ProcessOperatorName { get; set; }

        [Column("Isolation_Verified_Date")]
        public DateTime IsolationVerifiedDate { get; set; }

        [Column("Reason_Isolation_Not_Verified")]
        public string ReasonIsolationNotVerified { get; set; }

        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }


    }
}
