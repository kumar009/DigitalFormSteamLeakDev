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
    [Table("T_Comments_Session")]
    public class CommentsSession : ICommentsSession
    {
        [Key]
        [Column("Comments_Id")]
        public Guid CommentsId { get; set; }

        [Required]
        [Column("Comments_Notes")]
        public string CommentNotes { get; set; }

        [Required]
        [Column("Commenter_Name")]
        public string CommenterName { get; set; }

        [Required]
        [Column("Date_Commented")]
        public DateTime DateCommented { get; set; }



        [Required]
        [Column("Leak_Details_Id")]
        public Guid LeakDetailsId { get; set; }

        public virtual LeakDetails LeakDetails { get; set; }
    }
}
