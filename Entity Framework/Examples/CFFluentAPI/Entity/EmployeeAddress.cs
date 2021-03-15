using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI.Entity
{
    class EmployeeAddress
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        //Navigation Properties
        public virtual Employee Employee { get; set; }
    }
}
