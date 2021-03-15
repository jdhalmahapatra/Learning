using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    class Student
    {
        [Key]
        public int RegNo { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime Birthdate { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }

        //[ForeignKey("Programme")]
        public int ProgrammeId { get; set; }


        //navigation property
        [ForeignKey("ProgrammeId")]
        public virtual Programme Programme { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
    }
}
