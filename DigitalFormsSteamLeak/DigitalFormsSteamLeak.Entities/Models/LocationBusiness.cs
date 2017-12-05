using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalFormsSteamLeak.Entity.IModels;

namespace DigitalFormsSteamLeak.Entity.Models
{
    [Table("dbo.T_Location_Business")]
    public class LocationBusiness : ILocationBusiness
    {
        [Key]
        [Column("Business_Location_Id")]
        public Guid BusinessLocationId { get; set; }

        [Required]
        [Column("Business_Name")]
        public string BusinessName { get; set; }

        [Required]
        [Column("Department_Id")]
        public Guid DepartmentId { get; set; }

        public virtual LocationDepartment department { get; set; }

        public virtual ICollection<LocationUnit> Unit { set; get; }

    }
}