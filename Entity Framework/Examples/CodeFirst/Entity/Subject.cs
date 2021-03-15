using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        //Navigation Property
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}
