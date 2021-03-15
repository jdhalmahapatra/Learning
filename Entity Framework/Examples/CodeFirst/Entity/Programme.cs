using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    [Table("Course")]
    class Programme
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } //PK

        [Required]
        [Column("CourseName", TypeName ="varchar")]
        [MaxLength(50)]
        public string Title { get; set; }
        public int Duration { get; set; }
        public float Fees { get; set; }


        //Navigation Property (As per the rule we define , 1 Programme can have many students, 
        //So Programme class needs to have a ICollection Property. And It should be public and virtual)
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
