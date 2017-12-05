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
    [Table("dbo.T_Leak_Type")]
    public class LeakType : ILeakType
    {
        [Key]
        [Column("Leak_Type_Id")]
        public Guid LeakTypeId { get; set; }

        [Column("Leak_Type_Name")]
        [Required(ErrorMessage="Leak Type Name is Required")]
        public string LeakTypeName { get; set; }

        public virtual ICollection<LeakDetails> leakDetails { get; set; }
    }
}