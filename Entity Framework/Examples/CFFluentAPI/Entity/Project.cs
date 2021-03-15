using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI.Entity
{
    class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }

        //Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
