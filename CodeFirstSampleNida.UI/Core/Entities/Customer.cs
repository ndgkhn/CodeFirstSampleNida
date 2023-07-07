using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleNida.UI.Core.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

      
        public string Name { get; set; }
        public string Address { get; set; }

        
        public string Phone { get; set; }

  
        public int Aktifmi { get; set; }


        //public List<Employee> Employees { get; set; } //navigation property
       public List<CustomerEmployee1> CustomerEmployees1 { get; set; }
    }
}
