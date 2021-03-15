using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI.Entity
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime DOB { get; set; }
        public int DeptId { get; set; }
        public int? TeamId { get; set; }
        //Navigation Properties
        public virtual Department Department { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
