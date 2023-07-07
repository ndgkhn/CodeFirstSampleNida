using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleNida.UI.Core.Entities
{
    public class CustomerEmployee1
    {
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
        public Customer Customer { get; set; }


    }
}
