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
    [Table("T_Location_Department")]
    public class LocationDepartment : ILocationDepartment
    {
        [Key]
        [Column("Department_Id")]
        public Guid DepartmentId { get; set; }

        [Required]
        [Column("Department_Name")]
        public string DepatmentName { get; set; }


        public virtual ICollection<LocationBusiness> Business { set; get; }
    }
}