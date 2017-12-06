using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Week11.Models.ClubModel
{
    [Table("Member")]
    public class Member
    {   
        [Key,Column(Order =1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int memberID { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("club")]
        public int ClubId { get; set; }


        [Key, Column(Order = 3)]
        [ForeignKey("student")]
        public string StudentID { get; set; }

        public bool approved { get; set; }

        public virtual Club club { get; set; }
        public virtual Student student { get; set; }
    }
}