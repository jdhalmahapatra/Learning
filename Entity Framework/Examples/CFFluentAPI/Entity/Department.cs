using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI.Entity
{
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        //Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
