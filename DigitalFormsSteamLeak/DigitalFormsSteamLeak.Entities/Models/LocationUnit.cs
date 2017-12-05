using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalFormsSteamLeak.Entity.IModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalFormsSteamLeak.Entity.Models
{
    [Table("T_Location_Unit")]
    public class LocationUnit : ILocationUnit
    {
        [Key]
        [Required]
        [Column("Unit_Id")]
        public Guid UnitId { get; set; }

        [Required]
        [Column("Unit_Name")]
        public string UnitName { get; set; }

        [Required]
        [Column("Business_Location_Id")]
        public Guid BusinessLocationId { get; set; }

        public virtual LocationBusiness Business { get; set; }
        public virtual ICollection<LeakDetails> leakDetails { get; set; }

    }
}