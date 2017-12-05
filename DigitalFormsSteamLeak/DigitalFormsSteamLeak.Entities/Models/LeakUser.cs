using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Entity.Models
{
    [Table("T_User")]
    public class LeakUser : ILeakUser
    {
        [Key]
        [Column("User_Id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("User_Name")]
        public string UserName { get; set; }

        public virtual ICollection<LeakDetails> leakDetails { get; set; }
    }
}
