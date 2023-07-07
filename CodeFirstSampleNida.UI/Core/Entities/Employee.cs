using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleNida.UI.Core.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }

  
        public string Name { get; set; }

     
        public string Branch { get; set; }


       // public List<Customer> Customers { get; set; } //navigation property
       public List<CustomerEmployee1> CustomerEmployees1 { get; set; }
    }
}
