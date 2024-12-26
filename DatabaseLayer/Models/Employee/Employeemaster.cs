using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models.Employee
{
    [Table("EMPmaster")]
    public  class Employeemaster
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }

    }
}
