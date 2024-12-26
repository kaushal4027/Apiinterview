using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Models.Employee;

namespace BusinessLayer.Interface
{
    public  interface EmployeeINF
    {
        Task<IEnumerable<Employeemaster>> employeeAllList();

        Task<string> createEmployee(Employeemaster employeemaster);

        Task<Employeemaster> EditEmployee(int id);

        Task<string> PostEditEmployee(Employeemaster employeemaster);

        Task<string> DeleteEmployee(int id);
    }
}
